using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

	public void Numbers()
	{
		SceneManager.LoadScene("Numero");
	}

	public void Shapes()
	{
		SceneManager.LoadScene("Hugis");
	}

	public void Colorsres()
	{
		SceneManager.LoadScene("RaycastTry");
	}

	public void BodyParts()
	{
		SceneManager.LoadScene("Katawan");
	}

	public void MainMenu()
	{
		SceneManager.LoadScene("Main");
	}
}
