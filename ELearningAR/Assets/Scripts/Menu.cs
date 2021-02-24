using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	public void About()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("About");
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

	public void QuizLevels()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("QuizLevels");
	}

	public void Lesson()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("Lessons");
	}

	private string myURL = "http://www.facebook.com/billyjoeazur123";
	public void GoURL()
	{
		Application.OpenURL(myURL);
	}
}
