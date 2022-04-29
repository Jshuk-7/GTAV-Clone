using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
  public int triggerNumber;

  void OnTriggerEnter(Collider other)
  {
    Vector3 nextPosition = transform.position;
    if (other.tag == "NPC")
    {
      if (triggerNumber == 4)
      {
        triggerNumber = 0;
      }
      if (triggerNumber == 3)
      {
        nextPosition.z -= 78;
        transform.position = nextPosition;
        triggerNumber = 4;
      }
      if (triggerNumber == 2)
      {
        nextPosition.x += 59;
        transform.position = nextPosition;
        triggerNumber = 3;
      }
      if (triggerNumber == 1)
      {
        nextPosition.z += 78;
        transform.position = nextPosition;
        triggerNumber = 2;
      }
      if (triggerNumber == 0)
      {
        nextPosition.x -= 59;
        transform.position = nextPosition;
        triggerNumber = 1;
      }
    }
  }
}
