using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalHints : MonoBehaviour
{
  public GameObject hintText;
  public static int hintNumber;

  void Update()
  {
    if (hintNumber == 1)
    {
      hintNumber = 0;
      hintText.GetComponent<TextMeshProUGUI>().text = "Mission start points can be found by searching for the glowing orange circles on your map";
      hintText.SetActive(false);
      hintText.SetActive(true);
    }
    if (hintNumber == 2)
    {
      hintNumber = 0;
      hintText.GetComponent<TextMeshProUGUI>().text = "Use WASD to drive the vehicle. W and S drive forward and reverse. A and D turn left and right";
      hintText.SetActive(false);
      hintText.SetActive(true);
    }
  }
}
