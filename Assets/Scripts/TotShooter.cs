using UnityEngine;
using System.Collections;

public class TotShooter : MonoBehaviour 
{
	public GameObject tot;
	public float shootingForce;

	void Update()
	{
		if(Input.GetButtonDown ("Fire1"))
		{
			GameObject obj = (GameObject)Instantiate(tot, transform.position, transform.rotation);
			obj.transform.Rotate (90f, 0f, 0f);
			obj.rigidbody.AddRelativeForce(0f, shootingForce, 0f);
		}
	}
}
