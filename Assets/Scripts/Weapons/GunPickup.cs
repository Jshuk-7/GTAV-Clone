using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPickup : MonoBehaviour
{
  public GameObject gun;
  public AudioSource pickupSound;
  public GameObject pistolFireObject;

  void OnTriggerEnter(Collider other)
	{
    if (other.tag == "Player")
    {
      pickupSound.Play();
      gun.SetActive(true);
      pistolFireObject.SetActive(true);
      this.gameObject.SetActive(false);
    }
  }
}
