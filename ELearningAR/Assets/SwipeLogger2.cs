using UnityEngine;

public class SwipeLogger2 : MonoBehaviour
{
	public GameObject[] shapes;
	int j = 0;

	private void Awake()
	{
		SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
		shapes[0].SetActive(true);
	}

	private void SwipeDetector_OnSwipe(SwipeData data)
	{
		Debug.Log("Swipe in Direction: " + data.Direction);
		if (j <= shapes.Length)
		{
			if (data.Direction.ToString() == "Left")
			{
				shapes[j].SetActive(false);
				if (j == shapes.Length - 1)
				{
					j = shapes.Length - 1;
				}
				else
				{
					j++;
				}
			}

			else if (data.Direction.ToString() == "Right")
			{
				shapes[j].SetActive(false);

				if (j == 0)
				{
					j = 0;
				}
				else
				{
					j--;
				}
			}
			shapes[j].SetActive(true);

			Debug.Log(shapes[j]);
		}
	}
}
