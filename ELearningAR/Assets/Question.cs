using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
	public GameObject Responce, correctText, wrongText;
	
	public void ClickCorrect()
	{
		Responce.SetActive(true);
		correctText.SetActive(true);
		wrongText.SetActive(false);
	}

	public void ClickWrong()
	{
		Responce.SetActive(true);
		correctText.SetActive(false);
		wrongText.SetActive(true);
	}

	public void NextQuestion()
	{
		ResponceReset();
	}

	private void ResponceReset()
	{
		Responce.SetActive(false);
		correctText.SetActive(false);
		wrongText.SetActive(false);
	}
}
