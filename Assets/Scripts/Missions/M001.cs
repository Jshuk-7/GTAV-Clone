using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M001 : MonoBehaviour
{
  public GameObject miniMapLocation;
  public GameObject missionStartPoint;
  public GameObject phone;
  public GameObject sendMessage;
  public AudioSource phoneSFX;
  public GameObject tonyB;

  void OnTriggerEnter(Collider other)
	{
    StartCoroutine(MissionBegin());
  }

  IEnumerator MissionBegin()
	{
    GetComponent<BoxCollider>().enabled = false;
    miniMapLocation.SetActive(false);
    phone.SetActive(true);
    phoneSFX.Play();
    tonyB.SetActive(true);
    yield return new WaitForSeconds(3.5f);
    sendMessage.SetActive(true);
    yield return new WaitForSeconds(2);
    phone.SetActive(false);
    missionStartPoint.SetActive(false);
  }
}
