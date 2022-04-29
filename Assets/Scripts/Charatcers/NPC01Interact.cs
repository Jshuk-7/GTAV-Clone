using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC01Interact : MonoBehaviour
{
  public AudioSource[] voiceLines;
  public int randomNumber;

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
			StartCoroutine(NPCVoiceOver());
    }
  }

  IEnumerator NPCVoiceOver()
  {
    GetComponent<BoxCollider>().enabled = false;
    randomNumber = Random.Range(0, 3);
    voiceLines[randomNumber].Play();
    yield return new WaitForSeconds(2);
    GetComponent<BoxCollider>().enabled = true;
  }
}
