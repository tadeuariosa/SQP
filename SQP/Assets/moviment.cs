﻿using UnityEngine;

public class moviment : MonoBehaviour {

	public Rigidbody Rb;


	// Use this for initialization
	void Start () {

		Rb.useGravity = true;
	

		}
	
	// Update is called once per frame
	void Update()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, 0, 0);
		transform.Translate(x, 0, z);
	}
}