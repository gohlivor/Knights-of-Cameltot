using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	public Text scoreText;
	public float time = 10f;

	int score = 0;
	bool gameOver = false;

	void Update()
	{
		if(gameOver) return;
		
		time -= Time.deltaTime;
		if(time < 0f)
		{
			scoreText.text = "Game Over. Your Score Is: " + score;
			gameOver = true;
		}
	}

	public void Score()
	{
		if(gameOver) return;

		score++;
		scoreText.text = "Score: " + score;
	}

}
