using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour {

	public float _enemyMoveSpeed;
	public bool _moveRight;
	public Transform _wallCheck;
	public float _wallCheckRadius;
	public LayerMask _whatIsWall;
	private bool _hittingWall;
	private bool _notAtEdge;
	public Transform _edgeCheck;
	private Rigidbody _rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// _hittingWall = Physics.OverlapSphere(_wallCheck.position, _wallCheckRadius, _whatIsWall);

		// _notAtEdge = Physics.OverlapSphere(_edgeCheck.position, _wallCheckRadius, _whatIsWall);

		// if(_hittingWall || _notAtEdge) {
		// 	_moveRight = !_moveRight;
		// }

		// if(_moveRight) {
		// 	transform.localScale = new Vector3(-1f, 1f, 1f);
		// 	_rb.velocity = new Vector3(_enemyMoveSpeed, _rb.velocity.y, _rb.velocity.z);
		// } else {
		// 	transform.localScale = new Vector3(1f, 1f, 1f);
		// 	_rb.velocity = new Vector3(-_enemyMoveSpeed, _rb.velocity.y, _rb.velocity.z);
		// }
	}
}
