using UnityEngine;
using System.Collections;

public class TeddyScript : MonoBehaviour 
{
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
		}
	}
}
