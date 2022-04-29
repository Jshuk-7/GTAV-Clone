using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalAmmo : MonoBehaviour
{
	public static int pistolShots;
  public GameObject ammoDisplay;

  void Update()
  {
    ammoDisplay.GetComponent<TextMeshProUGUI>().text = "" + pistolShots;
  }
}
