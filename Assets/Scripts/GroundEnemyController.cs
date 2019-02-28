using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemyController : MonoBehaviour {

	public float _enemySpeed;
	public float _rayDistance;
	private bool _isRight;
	public Transform _groundSpot;
	

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * -_enemySpeed * Time.deltaTime);

		RaycastHit2D _groundDetect = Physics2D.Raycast(_groundSpot.position, Vector2.down, _rayDistance);
		if(_groundDetect.collider == false) {
			if(_isRight == true) {
				transform.eulerAngles = new Vector3(0, 0, 0);
				_isRight = false;
			} else {
				transform.eulerAngles = new Vector3(0, -180, 0);
				_isRight = true;
			}
		}
	}
}
