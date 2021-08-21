using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
	public Set[] myset;
	public Text Q, A, B, C, D, correctAnswer, answerOutput, total, scoreDisplay, scoreDisplay2, highestScore;
	public Image img;
	public GameObject highestScorePanel;
	int i= 0;
	int score;
	
	private void Start()
	{
		for (int positionArray = 0; positionArray < myset.Length; positionArray++)
		{
			Set obj = myset[positionArray];
			int randomizeArray = Random.Range(0, positionArray);
			myset[positionArray] = myset[randomizeArray];
			myset[randomizeArray] = obj;
		}

		Q.text = myset[i].Q;
		A.text = myset[i].A;
		B.text = myset[i].B;
		C.text = myset[i].C;
		D.text = myset[i].D;
		correctAnswer.text = myset[i].correctAnswer;
		img.GetComponent<Image>().sprite = myset[i].img;

		PlayerPrefs.SetInt("CurrentScore", 0);
		//PlayerPrefs.SetInt("HighestScore", 0);
	}

	private void Update()
	{
		int tot = i + 1;
		total.text = tot + "/" + myset.Length.ToString();
		scoreDisplay.text = "Score: " + score.ToString();
		if (i >= myset.Length)
		{
			highestScorePanel.SetActive(true);
			total.gameObject.SetActive(false);
			scoreDisplay2.text = "Score " + score.ToString();
			
			if (score > PlayerPrefs.GetInt("HighestScore", 0))
			{
				PlayerPrefs.SetInt("HighestScore", score);
				//highestScore.text = score.ToString();
			}
			highestScore.text = "Highest Score " + PlayerPrefs.GetInt("HighestScore").ToString();
		}
	}

	public void LetterA()
	{
		if (correctAnswer.text == "A")
		{
			answerOutput.text = "Correct";
			FindObjectOfType<AudioManager>().Play("correct");
			score += 1;
		}
		else
		{
			answerOutput.text = "Wrong";
			FindObjectOfType<AudioManager>().Play("wrong");
		}
		i++;
		if (i < myset.Length)
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
		}
		else
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
			
		}
	}

	public void LetterB()
	{
		if (correctAnswer.text == "B")
		{
			answerOutput.text = "Correct";
			FindObjectOfType<AudioManager>().Play("correct");
			score += 1;
		}
		else
		{
			answerOutput.text = "Wrong";
			FindObjectOfType<AudioManager>().Play("wrong");
		}
		i++;
		if (i < myset.Length)
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
		}
		else
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
		}
	}

	public void LetterC()
	{
		if (correctAnswer.text == "C")
		{
			answerOutput.text = "Correct";
			FindObjectOfType<AudioManager>().Play("correct");
			score += 1;
		}
		else
		{
			answerOutput.text = "Wrong";
			FindObjectOfType<AudioManager>().Play("wrong");
		}
		i++;
		if (i < myset.Length)
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
		}
		else
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
			
		}
	}

	public void LetterD()
	{
		if (correctAnswer.text == "D")
		{
			answerOutput.text = "Correct";
			FindObjectOfType<AudioManager>().Play("correct");
			score += 1;
		}
		else
		{
			answerOutput.text = "Wrong";
			FindObjectOfType<AudioManager>().Play("wrong");
		}
		i++;
		if (i < myset.Length)
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
		}
		else
		{
			Q.text = myset[i].Q;
			A.text = myset[i].A;
			B.text = myset[i].B;
			C.text = myset[i].C;
			D.text = myset[i].D;
			correctAnswer.text = myset[i].correctAnswer;
			img.GetComponent<Image>().sprite = myset[i].img;
			
		}
	}

}

