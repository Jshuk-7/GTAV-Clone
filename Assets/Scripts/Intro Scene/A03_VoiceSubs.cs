using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace GTA.IntroVoices
{
  public class A03_VoiceSubs : MonoBehaviour
  {
    public GameObject subText;
    public AudioSource voiceLine01;
    public AudioSource voiceLine02;
    public AudioSource voiceLine03;
    public AudioSource voiceLine04;
    public AudioSource voiceLine05;
    public AudioSource gunshot;
    public GameObject fullBlack;
    public GameObject deathObject;
    public GameObject theSack;
    public GameObject theCop;
    public GameObject character;
    public GameObject theGun;
    public GameObject fourthCamera;
    public GameObject fadeOut;

    void Start()
    {
      StartCoroutine(IntroSubs());
    }

    IEnumerator IntroSubs()
    {
      yield return new WaitForSeconds(10);
      subText.GetComponent<TextMeshProUGUI>().text = "You asked for this George.";
      voiceLine01.Play();
      subText.SetActive(true);
      yield return new WaitForSeconds(1.4f);
      subText.GetComponent<TextMeshProUGUI>().text = "";
      yield return new WaitForSeconds(0.8f);
      subText.GetComponent<TextMeshProUGUI>().text = "Lorenzo, I swear it wasn't me";
      voiceLine02.Play();
      yield return new WaitForSeconds(2.1f);
      subText.GetComponent<TextMeshProUGUI>().text = "";
      yield return new WaitForSeconds(0.2f);
      subText.GetComponent<TextMeshProUGUI>().text = "You squeal on Horseface, you're sleepin' with the fishes.";
      voiceLine03.Play();
      yield return new WaitForSeconds(2.7f);
      subText.GetComponent<TextMeshProUGUI>().text = "";
      yield return new WaitForSeconds(0.1f);
      subText.GetComponent<TextMeshProUGUI>().text = "Lorenzo Please!";
      voiceLine04.Play();
      yield return new WaitForSeconds(0.7f);
      subText.GetComponent<TextMeshProUGUI>().text = "";
      yield return new WaitForSeconds(0.3f);
      gunshot.Play();
      fullBlack.SetActive(true);
      deathObject.SetActive(true);
      theSack.SetActive(false);
      theCop.SetActive(false);
      character.SetActive(false);
      theGun.SetActive(false);
      yield return new WaitForSeconds(2);
      subText.GetComponent<TextMeshProUGUI>().text = "My name is Steve Lorenzo...";
      voiceLine05.Play();
      yield return new WaitForSeconds(2);
      fullBlack.SetActive(false);
      fourthCamera.SetActive(true);
      subText.GetComponent<TextMeshProUGUI>().text = "Three years ago, Jimmy Horseface tried to have me whacked. Set me up.";
      yield return new WaitForSeconds(5);
      subText.GetComponent<TextMeshProUGUI>().text = "Now it's time for me to return that favour";
      yield return new WaitForSeconds(2.5f);
      fadeOut.SetActive(true);
      yield return new WaitForSeconds(3);
      SceneManager.LoadScene(2);
    }
  }
}
