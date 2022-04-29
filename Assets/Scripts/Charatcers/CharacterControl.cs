using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GTA.CharacterContoller
{
  public class CharacterControl : MonoBehaviour
  {
    public GameObject player;
    public float horizontalMove;
    public float verticalMove;
    public int stepNum;
    public bool isRunning;
    public static bool isStepping = false;
    public AudioSource footstep01;
    public AudioSource footstep02;
    public AudioSource footstep03;
    public AudioSource footstep04;

    void Update()
    {
      if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
      {
        player.GetComponent<Animation>().Play("Run");
        horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
        verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 8;
        isRunning = true;
        if (!isStepping) { StartCoroutine(RunSound()); }
        transform.Rotate(0, horizontalMove, 0);
        transform.Translate(0, 0, verticalMove);
      }
      else
      {
        if (!FiringPistol.isFiring)
        {
          player.GetComponent<Animation>().Play("Idle");
          isRunning = false;
        }
      }
    }

    IEnumerator RunSound()
    {
      if (isRunning && !isStepping)
      {
        isStepping = true;
        stepNum = Random.Range(1, 5);
        switch (stepNum)
        {
          case 1:
            footstep01.Play();
            break;
          case 2:
            footstep02.Play();
            break;
          case 3:
            footstep03.Play();
            break;
          case 4:
            footstep04.Play();
            break;
        }
      }
      yield return new WaitForSeconds(0.3f);
      isStepping = false;
    }
  }
}
