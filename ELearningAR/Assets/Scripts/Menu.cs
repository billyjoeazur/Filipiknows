using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Menu : MonoBehaviour
{
	public void Numbers()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Numero");
	}

	public void Shapes()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Hugis");
	}

	public void Colors()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Kulay");
	}

	public void BodyParts()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Katawan");
	}

	public void MainMenu()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Main");
	}

	public void Guide()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Guide");
	}

	public void Category()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Category");
	}

	public void Quiz()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Quiz");
	}

	public void Lesson()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Lesson");
	}
	
	private string myURL = "https://drive.google.com/file/d/1aSYriqxW1pZXrCX_dY2xYPIex7_uLh1O/view?usp=sharing";
	public void GoURL()
	{
		Application.OpenURL(myURL);
	}

	private bool onOff = false;
	public void ToggleFlash()
	{
		if (onOff == false)
		{
			CameraDevice.Instance.SetFlashTorchMode(true);
			onOff = true;
		}
		else
		{
			CameraDevice.Instance.SetFlashTorchMode(false);
			onOff = false;
		}
		FindObjectOfType<AudioManager>().Play("click");
	}

	
}
