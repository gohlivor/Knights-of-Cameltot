using UnityEngine;
using System.Collections;

public class TeddyScriptFinal : MonoBehaviour 
{
	public Transform[] spawnPoints;
	public ScoreManager scoreManager;

	AudioSource audioSource;
	
	void Start()
	{
		audioSource = GetComponent<AudioSource> ();
	}
	
	void OnCollisionEnter(Collision other)
	{
		if(other.transform.tag == "Tot")
		{
			Destroy (other.gameObject);
			audioSource.Play();

			Respawn();
		}
	}

	void Respawn()
	{
		int index = Random.Range (0, spawnPoints.Length);
		transform.position = spawnPoints[index].position;
		transform.rotation = spawnPoints [index].rotation;

		if(scoreManager != null)
			scoreManager.Score();
	}
}