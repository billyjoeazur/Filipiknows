using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMusicOff : MonoBehaviour
{
	public GameObject musicSource;
    void Start()
    {
		musicSource = FindObjectOfType<BGMusic>().gameObject;
		//musicSource.GetComponent<AudioSource>().enabled = false;
	}

    // Update is called once per frame
    void Update()
    {
		musicSource.GetComponent<AudioSource>().enabled = false;
	}
}
