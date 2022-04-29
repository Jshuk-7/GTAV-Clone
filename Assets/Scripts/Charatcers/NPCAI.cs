using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
  NavMeshAgent theAgent;
  public GameObject destinationPoint;
  public GameObject fleeDestination;
  public AudioSource helpMeSFX;
  public static bool fleeMode = false;
  public bool isFleeing = false;

  void Start()
  {
    theAgent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    if (!fleeMode)
    {
      theAgent.SetDestination(destinationPoint.transform.position);
    }
    else
    {
      theAgent.SetDestination(fleeDestination.transform.position);
      if (!isFleeing)
      {
        isFleeing = true;
        StartCoroutine(FleeingNPC());
      }
    }
  }

  IEnumerator FleeingNPC()
  {
    helpMeSFX.Play();
    yield return new WaitForSeconds(13);
    fleeMode = false;
    isFleeing = false;
    GetComponent<Animator>().Play("Walking");
    GetComponent<NavMeshAgent>().speed = 2.5f;
  }
}
