using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GTA.OpenWorldOpening
{
  public class AA_Opening : MonoBehaviour
  {
    public GameObject fadeIn;
    public GameObject theText;
    public GameObject firstCamera;
    public GameObject fadeOut;
    public GameObject character;
    public GameObject dummyCharacter;
    public GameObject cashCount;
    public GameObject ammoCount;
    public GameObject hintBox;
    public GameObject miniMap;

    void Start()
    {
      StartCoroutine(OpenBegin());
    }

    IEnumerator OpenBegin()
    {
      yield return new WaitForSeconds(1);
      theText.SetActive(true);
      yield return new WaitForSeconds(7);
      fadeIn.GetComponent<Animator>().enabled = true;
      firstCamera.GetComponent<Animator>().enabled = true;
      yield return new WaitForSeconds(6);
      fadeOut.SetActive(true);
      fadeIn.SetActive(false);
      yield return new WaitForSeconds(2.75f);
      dummyCharacter.SetActive(false);
      character.SetActive(true);
      firstCamera.SetActive(false);
      fadeOut.SetActive(false);
      fadeIn.SetActive(true);
      cashCount.SetActive(true);
      ammoCount.SetActive(true);
      hintBox.SetActive(true);
      miniMap.SetActive(true);
      fadeIn.GetComponent<Animator>().Play("FadeInAnim");
      yield return new WaitForSeconds(4);
      fadeIn.SetActive(false);
      GlobalHints.hintNumber = 1;
    }
  }
}
