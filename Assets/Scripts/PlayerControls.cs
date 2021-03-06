﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {


	public float _moveSpeed;
	public float _jumpHeight;
	public float _rayLength;
	private float _moveInput;
	private Rigidbody2D _rb;
	public GameManager _gm;

	public Transform _groundMark;
	public float _groundMarkRad;
	public LayerMask _isGroundMask;
	private bool _isGrounded;
	private Animator _anim;

	public GameObject _gameOverScreen;

	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody2D>();
		_anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		_isGrounded = Physics2D.OverlapCircle(_groundMark.position, _groundMarkRad, _isGroundMask);

		if(_moveInput > 0) {
			transform.eulerAngles = new Vector3(0, 0, 0);
			_anim.SetFloat("Speed", _moveSpeed);
		} else if(_moveInput < 0) {
			transform.eulerAngles = new Vector3(0, 180, 0);
			_anim.SetFloat("Speed", _moveSpeed);
		} else {
			_anim.SetFloat("Speed", 0);
		}

		

		if(_isGrounded) {
			if(Input.GetButtonDown("Jump")) {
				_rb.velocity = new Vector2(0, _jumpHeight);
			}
		}
	}

	void FixedUpdate() {
		_moveInput = Input.GetAxisRaw("Horizontal");
		_rb.velocity = new Vector2(_moveInput * _moveSpeed, _rb.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D other) {
		
		if(other.gameObject.tag == "killzone") {
			this.gameObject.SetActive(false);
			_gm._lives -= 1;
			_gm.CheckSpawn();
		}

		if(other.gameObject.tag == "enemy") {
			this.gameObject.SetActive(false);
			_gm._lives -= 1;
			_gm.CheckSpawn();
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		
		if(other.gameObject.tag == "gems") {
			other.gameObject.SetActive(false);
			_gm._gemAmount++;
		}

		if(other.gameObject.tag == "cherry") {
			other.gameObject.SetActive(false);
			_gm._cherryAmount++;
		}

		if(other.gameObject.tag == "win") {
			Debug.Log("You Win!");
			_gameOverScreen.gameObject.SetActive(true);
			this.gameObject.SetActive(false);
		}
	}
}
