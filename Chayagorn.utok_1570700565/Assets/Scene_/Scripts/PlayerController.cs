using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GameObject Shot;
	public Transform ShotSpawn;
	public float fireRate;
	public float nextFire;

	void Update()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			Instantiate(Shot,ShotSpawn.position, ShotSpawn.rotation);
		}
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		GetComponent<Rigidbody>().velocity = movement * speed;

	}
}
