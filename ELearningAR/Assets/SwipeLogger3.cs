using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLogger3 : MonoBehaviour
{
	public GameObject[] colors;
	int k = 0;

	private void Awake()
	{
		SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
		colors[0].SetActive(true);
	}

	private void SwipeDetector_OnSwipe(SwipeData data)
	{
		Debug.Log("Swipe in Direction: " + data.Direction);
		if (k <= colors.Length)
		{
			if (data.Direction.ToString() == "Left")
			{
				colors[k].SetActive(false);
				if (k == colors.Length - 1)
				{
					k = colors.Length - 1;
				}
				else
				{
					k++;
				}
			}

			else if (data.Direction.ToString() == "Right")
			{
				colors[k].SetActive(false);

				if (k == 0)
				{
					k = 0;
				}
				else
				{
					k--;
				}
			}
			colors[k].SetActive(true);

			Debug.Log(colors[k]);
		}
	}
}
