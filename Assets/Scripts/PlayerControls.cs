using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {


	public float _moveSpeed;
	public float _jumpHeight;
	public float _rayLength;
	private Rigidbody2D _rb;
	// public GameManager _gm;

	// Use this for initialization
	void Start () {
		_rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetAxis("Horizontal") != 0) {
			Vector2 pos = gameObject.transform.position;
			pos.x += Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
			gameObject.transform.position = pos;

			// float move = Input.GetAxis ("Horizontal");
			// anim.SetFloat("Speed", move);
		}

		if(isGrounded()) {
			if(Input.GetButtonDown("Jump")) {
				_rb.AddForce(Vector2.up * _jumpHeight);
				// _rb.velocity = new Vector2(0, _jumpHeight);
			}
		}
	}

	bool isGrounded() {
		return Physics2D.Raycast(transform.position, -Vector2.up, _rayLength);
	}

	// void OnCollisionEnter(Collision other) {
	// 	if(other.gameObject.tag == "killzone") {
	// 		Debug.Log("Touched");
	// 		_gm.CheckSpawn();
	// 	}
	// }
}
