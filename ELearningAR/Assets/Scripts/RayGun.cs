using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class RayGun : MonoBehaviour
{
	public Text objName;
	Rect buttonRect = new Rect(80f, -80f, 120f, 120f);
	Touch touch;
	Menu menu = new Menu();
	//public Camera fpsCam;

	void Update()
    {
		if (Input.touchCount > 0)
		{
			touch = Input.GetTouch(0);

			if (touch.position.x < 60f && touch.position.y > 515f)
			{
				Debug.Log("BACK TOUCH");
				menu.MainMenu();
			}

			else if (touch.position.x > 280f && touch.position.y > 515f)
			{
				Debug.Log("QUIZ TOUCH");
				//GO TO QUIZ SCENE
			}

			else if (Input.touches[0].phase == TouchPhase.Began)
			{
				Shoot();
				Debug.Log("shotness");
			}

		}
	}

	public void Shoot()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider != null)
			{
				//Debug.Log("TOUCH!!!");
				Debug.Log(hit.transform.name.ToString());
				objName.text = hit.transform.name;
			}
		}
	}

}
