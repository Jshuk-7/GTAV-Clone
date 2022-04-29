using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using GTA.CharacterContoller;
using TMPro;

public class VehicleExit : MonoBehaviour
{
  [SerializeField] GameObject thirdPersonCamera;
  [SerializeField] GameObject firstPersonCamera;
  [SerializeField] GameObject character;
  [SerializeField] GameObject vehicle;
  [SerializeField] GameObject vehicleEntryTrigger;
  [SerializeField] GameObject miniMapCamera;
  [SerializeField] GameObject playerPoint;
  [SerializeField] AudioSource ambiance;
  [SerializeField] bool isUsingFirstPersonCamera = false;

  void EnableFirstPersonCamera()
  {
    firstPersonCamera.SetActive(true);
    thirdPersonCamera.SetActive(false);
  }

  void EnableThirdPersonCamera()
  {
    firstPersonCamera.SetActive(false);
    thirdPersonCamera.SetActive(true);
  }

  void ToggleCameraView()
  {
    isUsingFirstPersonCamera = !isUsingFirstPersonCamera;
    if (isUsingFirstPersonCamera)
    {
      EnableFirstPersonCamera();
    }
    else
    {
      EnableThirdPersonCamera();
    }
  }

  void GetOutOfCar()
  {
    character.SetActive(true);
    thirdPersonCamera.SetActive(false);
    firstPersonCamera.SetActive(false);
    playerPoint.SetActive(false);
    vehicle.GetComponent<CarController>().enabled = false;
    vehicle.GetComponent<CarUserControl>().enabled = false;
    vehicle.GetComponent<CarAudio>().enabled = false;
    character.transform.parent = null;
    miniMapCamera.transform.parent = character.transform;
    miniMapCamera.transform.localEulerAngles = new Vector3(90, 0, 0);
    miniMapCamera.transform.localPosition = new Vector3(0, 25, 0);
    vehicle.GetComponent<CarAudio>().StopSound();
    CharacterControl.isStepping = false;
    ambiance.Play();
    StartCoroutine(EnterAgain());
  }

	void Update()
	{
    if (Input.GetKeyDown(KeyCode.E))
    {
      GetOutOfCar();
    }
    if (Input.GetKeyDown(KeyCode.Tab))
    {
      ToggleCameraView();
    }
	}

	IEnumerator EnterAgain()
	{
    yield return new WaitForSeconds(0.5f);
    vehicleEntryTrigger.GetComponent<BoxCollider>().enabled = true;
    gameObject.SetActive(false);
  }
}
