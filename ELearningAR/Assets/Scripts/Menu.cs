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


	public void QuizNumbers()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("QuizNumero");
	}

	public void QuizShapes()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("QuizHugis");
	}

	public void QuizColors()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("QuizKulay");
	}

	public void QuizBodyParts()
	{
		FindObjectOfType<AudioManager>().Play("click");
		SceneManager.LoadScene("QuizKatawan");
	}
}
