using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GTA.CharacterContoller;

public class M001_A : MonoBehaviour
{
  public GameObject tonyCamera;
  public GameObject character;
  public GameObject fadeIn;
  public GameObject fadeOut;
  public GameObject subtitle;
  public AudioSource tonyLine01;
  public GameObject cashCount;
  public GameObject ammoCount;
  public GameObject hintBox;
  public GameObject miniMap;

	void OnTriggerEnter(Collider other)
	{
    StartCoroutine(TonyMeet());
  }

	IEnumerator TonyMeet()
	{
    GetComponent<BoxCollider>().enabled = false;
    fadeOut.SetActive(true);
    yield return new WaitForSeconds(1.5f);
    cashCount.SetActive(false);
    ammoCount.SetActive(false);
    hintBox.SetActive(false);
    miniMap.SetActive(false);
    tonyCamera.SetActive(true);
    character.GetComponent<CharacterControl>().enabled = false;
    fadeIn.SetActive(true);
    fadeOut.SetActive(false);
    yield return new WaitForSeconds(1.5f);
    fadeIn.SetActive(false);
    subtitle.SetActive(true);
    tonyLine01.Play();
    yield return new WaitForSeconds(7);
    subtitle.SetActive(false);
    yield return new WaitForSeconds(0.5f);
    fadeOut.SetActive(true);
    yield return new WaitForSeconds(1.5f);
    tonyCamera.SetActive(false);
    character.GetComponent<CharacterControl>().enabled = true ;
    fadeIn.SetActive(true);
    fadeOut.SetActive(false);
    cashCount.SetActive(true);
    ammoCount.SetActive(true);
    hintBox.SetActive(true);
    miniMap.SetActive(true);
    yield return new WaitForSeconds(1.5f);
    fadeIn.SetActive(false);
  }
}
