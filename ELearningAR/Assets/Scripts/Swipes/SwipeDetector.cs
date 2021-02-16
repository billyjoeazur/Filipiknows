using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SwipeDetector : MonoBehaviour
{
	private Vector2 fingerDownPosition;
	private Vector2 fingerUpPosition;

	[SerializeField]
	private bool detectSwipeOnlyAfterRelease = false;

	[SerializeField]
	private float minDistanceForSwipe = 20f;

	public static event Action<SwipeData> OnSwipe = delegate { };

	private void Update()
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

	private void DetectSwipe()
	{
		if (SwipeDistanceCheckMet())
		{
			if (IsVerticalSwipe())
			{
				//var direction = fingerDownPosition.y - fingerUpPosition.y > 0 ? SwipeDirection.Up : SwipeDirection.Down;
				//SendSwipe(direction);
			}
			else
			{
				var direction = fingerDownPosition.x - fingerUpPosition.x > 0 ? SwipeDirection.Right : SwipeDirection.Left;
				SendSwipe(direction);
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

	private bool IsVerticalSwipe()
	{
		return VerticalMovementDistance() > HorizontalMovementDistance();
	}

	private bool SwipeDistanceCheckMet()
	{
		return VerticalMovementDistance() > minDistanceForSwipe || HorizontalMovementDistance() > minDistanceForSwipe;
	}

	private float VerticalMovementDistance()
	{
		return Mathf.Abs(fingerDownPosition.y - fingerUpPosition.y);
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
}

//public struct SwipeData
//{
//	public Vector2 StartPosition;
//	public Vector2 EndPosition;
//	public SwipeDirection Direction;
//}

//public enum SwipeDirection
//{
//	Up,
//	Down,
//	Left,
//	Right
//}