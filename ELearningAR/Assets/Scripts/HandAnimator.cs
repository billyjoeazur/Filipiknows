using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator : MonoBehaviour
{
	public GameObject panel1, panel2;

    void Start()
    {
        
    }

    public void ClosePanel1()
	{
		panel1.SetActive(false);
		panel2.SetActive(true);
	}

	public void ClosePanel2()
	{
		panel2.SetActive(false);
	}
}
