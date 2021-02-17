using System;
using UnityEngine;
using UnityEngine.UI;

public class SwipeControl : MonoBehaviour
{
	private GameObject[] myList;
	private int i;

	private Vector2 fingerDownPosition, fingerUpPosition;
	[SerializeField]
	private bool detectSwipeOnlyAfterRelease = false;
	[SerializeField]
	private float minDistanceForSwipe = 20f;
	public static event Action<SwipeData> OnSwipe = delegate { };

	void Start()
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

    void Update()
    {
		foreach (Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				fingerUpPosition = touch.position;
				fingerDownPosition = touch.position;

			}

			if (!detectSwipeOnlyAfterRelease && touch.phase == TouchPhase.Moved)
			{
				fingerDownPosition = touch.position;
				DetectSwipe();
			}

			if (touch.phase == TouchPhase.Ended)
			{
				fingerDownPosition = touch.position;
				DetectSwipe();
			}
		}
	}

	private bool SwipeDistanceCheckMet()
	{
		return HorizontalMovementDistance() > minDistanceForSwipe;
	}
	private float HorizontalMovementDistance()
	{
		return Mathf.Abs(fingerDownPosition.x - fingerUpPosition.x);
	}

	private void SendSwipe(SwipeDirection direction)
	{
		SwipeData swipeData = new SwipeData()
		{
			Direction = direction,
			StartPosition = fingerDownPosition,
			EndPosition = fingerUpPosition
		};
		OnSwipe(swipeData);
	}

	private void DetectSwipe()
	{
		if (SwipeDistanceCheckMet())
		{

			if(fingerDownPosition.x - fingerUpPosition.x > 0 )
			{
				SwipeLeft();
			}
			else
			{
				SwipeRight();
			}

			fingerUpPosition = fingerDownPosition;
		}
		else
		{
			Speak();
		}
	}

	public Text objName;
	private void Speak()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider != null)
			{
				Debug.Log(hit.transform.name.ToString());
				objName.text = hit.transform.name;
				string audioname = hit.transform.name;
				FindObjectOfType<AudioManager>().Play(audioname);
			}
		}
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

public struct SwipeData
{
	public Vector2 StartPosition;
	public Vector2 EndPosition;
	public SwipeDirection Direction;
}

public enum SwipeDirection
{
	Left,
	Right
}
