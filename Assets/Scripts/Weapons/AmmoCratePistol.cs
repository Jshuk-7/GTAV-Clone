using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCratePistol : MonoBehaviour
{
  public GameObject crate;
  public AudioSource gunPickup;

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      StartCoroutine(SetAmmo());
    }
  }

  IEnumerator SetAmmo()
  {
    crate.GetComponent<Animation>().Play();
    yield return new WaitForSeconds(1.7f);
    gunPickup.Play();
    GlobalAmmo.pistolShots += 15;
    Destroy(gameObject);
  }
}
