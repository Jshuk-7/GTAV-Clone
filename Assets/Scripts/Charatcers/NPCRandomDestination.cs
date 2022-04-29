using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRandomDestination : MonoBehaviour
{
  public int generatePosition;

  void OnTriggerEnter(Collider other)
  {
    Vector3 nextPosition = transform.position;
    if (other.tag == "NPC")
    {
      generatePosition = Random.Range(1, 5);
      if (generatePosition == 4)
      {
        nextPosition.x -= 61;
        nextPosition.z -= 20;
        transform.position = nextPosition;
      }
      if (generatePosition == 3)
      {
        nextPosition.x -= 30;
        nextPosition.z += 20;
        transform.position = nextPosition;
      }
      if (generatePosition == 2)
      {
        nextPosition.z += 109;
        transform.position = nextPosition;
      }
      if (generatePosition == 1)
      {
        transform.position = nextPosition;
      }
    }
  }
}
