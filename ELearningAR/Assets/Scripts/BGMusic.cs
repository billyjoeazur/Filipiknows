using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
	//public GameObject musicOn, musicOff;
	public GameObject musicSource;

	public static BGMusic instance;

	private void Awake()
	{
		if (instance == null)
			instance = this;
		else
		{
			Destroy(gameObject);
			return;
		}


		DontDestroyOnLoad(gameObject);
	}

	private void Start()
	{
		//CheckMusicStatus();
	}
	private void Update()
	{
		CheckMusicStatus();
		
	}

	//public void offMusic()
	//{

	//	musicOn.SetActive(true);
	//	musicOff.SetActive(false);
	//	PlayerPrefs.SetInt("status", 0);
	//	musicSource.SetActive(true);
	//}

	//public void onMusic()
	//{

	//	musicOn.SetActive(false);
	//	musicOff.SetActive(true);
	//	PlayerPrefs.SetInt("status", 1);
	//	musicSource.SetActive(false);
	//}

	//playerPrefs ng music
	public void CheckMusicStatus()
	{
		if (PlayerPrefs.GetInt("status") == 0)
		{
			musicSource.GetComponent<AudioSource>().enabled = true;
			//musicOn.SetActive(true);

		}
		else
		{
			musicSource.GetComponent<AudioSource>().enabled = false;
			//musicOff.SetActive(true);

		}
	}
}
