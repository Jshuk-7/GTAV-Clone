using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GTA.CameraSwitcher
{
  public class A01_CameraSwitch : MonoBehaviour
  {
    public GameObject firstCamera;
    public GameObject secondCamera;
    public GameObject thirdCamera;
    public GameObject creditsLeadDev;
    public GameObject creditsStory;

    void Start()
    {
      StartCoroutine(CameraSwitcher());
    }

    IEnumerator CameraSwitcher()
    {
      yield return new WaitForSeconds(2);
      creditsLeadDev.SetActive(true);
      yield return new WaitForSeconds(7);
      creditsStory.SetActive(true);
      secondCamera.SetActive(true);
      firstCamera.SetActive(false);
      yield return new WaitForSeconds(5);
      thirdCamera.SetActive(true);
      secondCamera.SetActive(false);
    }
  }
}
