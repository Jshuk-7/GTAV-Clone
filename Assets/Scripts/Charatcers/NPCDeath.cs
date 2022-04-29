using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCDeath : MonoBehaviour
{
  public int npcHealth = 40;
  public GameObject npcObject;
  public GameObject interactionTrigger;
  public GameObject helpMe;
  public bool npcDead = false;

	void HurtNPC(int shotDamage)
	{
    npcHealth -= shotDamage;
  }

  void Update()
  {
    transform.position = npcObject.transform.position;
		if (npcHealth <= 0 && !npcDead)
		{
      npcDead = true;
      StartCoroutine(EndNPC());
    }
  }

	IEnumerator EndNPC()
	{
    GlobalWanted.wantedLevel++;
    GlobalWanted.activateStar = true;
    npcObject.GetComponent<NPCAI>().enabled = false;
    npcObject.GetComponent<NavMeshAgent>().enabled = false;
    npcObject.GetComponent<BoxCollider>().enabled = false;
    GetComponent<BoxCollider>().enabled = false;
    interactionTrigger.SetActive(false);
    yield return new WaitForSeconds(0.1f);
    npcObject.GetComponent<Animator>().Play("Dying");
    helpMe.SetActive(false);
    yield return new WaitForSeconds(3);
    npcObject.GetComponent<Animator>().enabled = false;
  }
}
