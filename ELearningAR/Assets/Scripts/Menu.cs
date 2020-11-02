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
}
