using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMute : MonoBehaviour
{
	public GameObject musicOn, musicOff;
	public GameObject musicSource;

	

	public void offMusic()
	{

		musicOn.SetActive(true);
		musicOff.SetActive(false);
		PlayerPrefs.SetInt("status", 0);
		musicSource.GetComponent<AudioSource>().enabled = true;
	}

	public void onMusic()
	{

		musicOn.SetActive(false);
		musicOff.SetActive(true);
		PlayerPrefs.SetInt("status", 1);
		musicSource.GetComponent<AudioSource>().enabled = false;
	}
	private void Start()
	{
		//PlayerPrefs.SetInt("status", 0);
		musicSource = FindObjectOfType<BGMusic>().gameObject;
	}

	private void Update()
	{
		if (PlayerPrefs.GetInt("status") == 0)
		{
			musicOn.SetActive(true);
			musicOff.SetActive(false);
		}
		else
		{
			musicOn.SetActive(false);
			musicOff.SetActive(true);
		}
	}
}
