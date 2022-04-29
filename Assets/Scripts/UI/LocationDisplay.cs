using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LocationDisplay : MonoBehaviour
{
  public GameObject locationDisplay;
  public string locationName;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
      GetComponent<BoxCollider>().enabled = false;
      locationDisplay.GetComponent<TextMeshProUGUI>().text = locationName;
      locationDisplay.GetComponent<Animator>().Play("LocationDisplay");
      StartCoroutine(ResetLocation());
    }
	}

	IEnumerator ResetLocation()
	{
    yield return new WaitForSeconds(7);
		locationDisplay.GetComponent<Animator>().Play("New State");
    GetComponent<BoxCollider>().enabled = true;
  }
}
