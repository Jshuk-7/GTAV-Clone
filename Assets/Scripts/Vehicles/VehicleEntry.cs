using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using TMPro;

public class VehicleEntry : MonoBehaviour
{
  [SerializeField] GameObject thirdPersonCamera;
  [SerializeField] GameObject firstPersonCamera;
  [SerializeField] GameObject character;
  [SerializeField] GameObject vehicle;
  [SerializeField] GameObject exitTrigger;
  [SerializeField] GameObject miniMapCamera;
  [SerializeField] GameObject vehicleInteractUi;
  [SerializeField] GameObject vehicleInteractText;
  [SerializeField] GameObject playerPoint;
  [SerializeField] AudioSource ambiance;
  [SerializeField] bool canEnter = false;

  void GetInCar()
  {
    GetComponent<BoxCollider>().enabled = false;
    thirdPersonCamera.SetActive(true);
    character.SetActive(false);
    playerPoint.SetActive(true);
    vehicle.GetComponent<CarController>().enabled = true;
    vehicle.GetComponent<CarUserControl>().enabled = true;
    vehicle.GetComponent<CarAudio>().enabled = true;
    canEnter = false;
    character.transform.parent = this.gameObject.transform;
    miniMapCamera.transform.parent = vehicle.transform;
    miniMapCamera.transform.localEulerAngles = new Vector3(90, 0, 0);
    miniMapCamera.transform.localPosition = new Vector3(0, 25, 0);
    vehicleInteractUi.GetComponentInChildren<RectTransform>().localPosition = new Vector3(0, 0, 0);
    vehicleInteractText.GetComponent<TextMeshProUGUI>().text = "";
    vehicleInteractUi.SetActive(false);
    ambiance.Stop();
    GlobalHints.hintNumber = 2;
    StartCoroutine(ExitTrigger());
  }

  void Update()
	{
		if (canEnter)
		{
			if (Input.GetKeyDown(KeyCode.E))
      {
        GetInCar();
      }
    }
	}

  void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
      canEnter = true;
      vehicleInteractUi.GetComponentInChildren<RectTransform>().localPosition = new Vector3(-42.2f, 175, 0);
      vehicleInteractText.GetComponent<TextMeshProUGUI>().text = "Press       to enter vehicle";
      vehicleInteractUi.SetActive(true);
    }
	}

	void OnTriggerExit(Collider other)
	{
    canEnter = false;
    vehicleInteractUi.GetComponentInChildren<RectTransform>().localPosition = new Vector3(0, 0, 0);
    vehicleInteractText.GetComponent<TextMeshProUGUI>().text = "";
		vehicleInteractUi.SetActive(false);
  }

	IEnumerator ExitTrigger()
	{
    yield return new WaitForSeconds(0.5f);
    exitTrigger.SetActive(true);
  }
}
