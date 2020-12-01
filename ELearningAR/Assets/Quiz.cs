using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
	public GameObject[] questions;
	

	public void Q1()
	{
		questions[0].SetActive(false);
		questions[1].SetActive(true);
	}

	public void Q2()
	{
		questions[1].SetActive(false);
		questions[2].SetActive(true);
	}

	public void Q3()
	{
		questions[2].SetActive(false);
		questions[3].SetActive(true);
	}

	public void Q4()
	{
		questions[3].SetActive(false);
	}

	public void Q5()
	{
		questions[4].SetActive(false);
	}


}

