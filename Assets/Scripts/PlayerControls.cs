﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {


	public float _moveSpeed;
	public float _jumpHeight;
	public float _rayLength;
	private Rigidbody _rb;

	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetAxis("Horizontal") != 0) {
			Vector3 pos = gameObject.transform.position;
			pos.x += Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
			gameObject.transform.position = pos;

			// float move = Input.GetAxis ("Horizontal");
			// anim.SetFloat("Speed", move);
		}

		if(isGrounded()) {
			if(Input.GetButtonDown("Jump")) {
				_rb.AddForce(Vector3.up * _jumpHeight, ForceMode.Impulse);
			}
		}
	}

	bool isGrounded() {
		return Physics.Raycast(transform.position, -Vector3.up, _rayLength);
	}
}