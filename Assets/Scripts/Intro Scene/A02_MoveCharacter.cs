using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GTA.CharacterMovement
{
  public class A02_MoveCharacter : MonoBehaviour
  {
    public AudioSource leftFoot;
    public AudioSource rightFoot;
    public bool steppingLeft = true;
    public GameObject mainChar;
    public int stepsTaken;
    void Start()
    {
      StartCoroutine(WalkSequence());
    }

    void Update()
    {
      mainChar.transform.Translate(0, 0, 0.00165f * Time.timeScale);
    }

    IEnumerator WalkSequence()
    {
      yield return new WaitForSeconds(0.4f);
      while (stepsTaken < 16)
      {
        yield return new WaitForSeconds(0.50f);
        if (steppingLeft)
        {
          leftFoot.Play();
          steppingLeft = false;
        }
        else
        {
          rightFoot.Play();
          steppingLeft = true;
        }
        stepsTaken += 1;
      }
      mainChar.SetActive(false);
    }
  }
}
