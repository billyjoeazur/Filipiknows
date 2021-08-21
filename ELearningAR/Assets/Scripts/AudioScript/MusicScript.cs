using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	public AudioClip bgMusic;
	public AudioSource musicSource;

	BGMusic bg = new BGMusic();

	void Start()
	{
		//musicSource.clip = bgMusic;
		//musicSource.Play();
		bg.CheckMusicStatus();
	}

	void Update()
	{

	}
}
