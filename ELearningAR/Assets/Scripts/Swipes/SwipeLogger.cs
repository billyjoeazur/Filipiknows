using UnityEngine;

public class SwipeLogger : MonoBehaviour
{

	//public GameObject[] numbers;
	//int i = 0;

	private GameObject[] myList;
	private int i;

	private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
		//numbers[0].SetActive(true);
    }

	private void Start()
	{
		myList = new GameObject[transform.childCount];

		// Fill the array with our models
		for (int i = 0; i < transform.childCount; i++)
			myList[i] = transform.GetChild(i).gameObject;

		// We toggle off their renderer
		foreach (GameObject go in myList)
			go.SetActive(false);

		// We toggle on the selected character
		if (myList[i])
			myList[i].SetActive(true);
	}

	private void SwipeDetector_OnSwipe(SwipeData data)
    {
		Debug.Log("Swipe in Direction: " + data.Direction);
		if (data.Direction.ToString() == "Left")
		{
			SwipeLeft();
		}
		else if (data.Direction.ToString() == "Right")
		{
			SwipeRight();
		}





		//if (i <= numbers.Length)
		//{
		//	if (data.Direction.ToString() == "Left")
		//	{
		//		numbers[i].SetActive(false);
		//		if (i == numbers.Length -1)
		//		{
		//			i = numbers.Length -1;
		//		}
		//		else
		//		{
		//			i++;
		//		}
		//	}

			//	else if (data.Direction.ToString() == "Right")
			//	{
			//		numbers[i].SetActive(false);

			//		if (i == 0)
			//		{
			//			i = 0;
			//		}
			//		else
			//		{
			//			i--;
			//		}
			//	}
			//	numbers[i].SetActive(true);

			//	Debug.Log(numbers[i]);
			//}
	}

	public void SwipeLeft()
	{
		//Toggle off the current model
		myList[i].SetActive(false);
		i--;
		if (i < 0)      //index = index - 1;
			i = myList.Length - 1;

		//Toggle on the new model
		myList[i].SetActive(true);
	}

	public void SwipeRight()
	{
		//Toggle off the current model
		myList[i].SetActive(false);
		i++;
		if (i == myList.Length)      //index = index - 1;
			i = 0;

		//Toggle on the new model
		myList[i].SetActive(true);
	}

}