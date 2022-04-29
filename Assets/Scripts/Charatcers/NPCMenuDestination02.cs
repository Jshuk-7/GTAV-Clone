using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMenuDestination02 : MonoBehaviour
{
  public int triggerNumber;

  void OnTriggerEnter(Collider other)
  {
    Vector3 nextPosition = transform.position;
    if (other.tag == "NPC")
    {
      if (triggerNumber == 2)
      {
        triggerNumber = 0;
      }
      if (triggerNumber == 1)
      {
        nextPosition.x += 60;
        transform.position = nextPosition;
        triggerNumber = 2;
      }
      if (triggerNumber == 0)
      {
        nextPosition.x -= 60;
        transform.position = nextPosition;
        triggerNumber = 1;
      }
    }
  }
}
