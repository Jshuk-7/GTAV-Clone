using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalWanted : MonoBehaviour
{
  public GameObject[] wantedStars;
  public static int wantedLevel;
  public bool isAddingStar;
  public static bool activateStar;

  void Update()
  {
    if (!isAddingStar && activateStar)
		{
      activateStar = false;
      isAddingStar = true;
      StartCoroutine(AddStar());
    }
  }

	IEnumerator AddStar()
	{
		for (int i = 0; i < wantedStars.Length; i++)
		{
			wantedStars[wantedLevel - 1].SetActive(true);
			yield return new WaitForSeconds(0.5f);
			wantedStars[wantedLevel - 1].SetActive(false);
			yield return new WaitForSeconds(0.5f);
		}
		wantedStars[wantedLevel--].SetActive(true);
  }
}
