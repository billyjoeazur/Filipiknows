using UnityEngine;

public class SwipeLogger : MonoBehaviour
{

	public GameObject[] numbers;
	int i = 0;

	private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
		numbers[0].SetActive(true);
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
		Debug.Log("Swipe in Direction: " + data.Direction);
		if (i <= numbers.Length)
		{
			if (data.Direction.ToString() == "Left")
			{
				numbers[i].SetActive(false);
				if (i == numbers.Length -1)
				{
					i = numbers.Length -1;
				}
				else
				{
					i++;
				}
			}

			else if (data.Direction.ToString() == "Right")
			{
				numbers[i].SetActive(false);
				
				if (i == 0)
				{
					i = 0;
				}
				else
				{
					i--;
				}
			}
			numbers[i].SetActive(true);

			Debug.Log(numbers[i]);
		}
		
	}

}