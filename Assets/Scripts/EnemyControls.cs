using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControls : MonoBehaviour {

	public float _enemySpeed;
	private float _standbyTime;
	public float _startWaitTime;
	public Transform[] _waypoints;
	private int _randomSpot;

	// Use this for initialization
	void Start () {
		_standbyTime = _startWaitTime;
		_randomSpot = Random.Range(0, _waypoints.Length);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, _waypoints[_randomSpot].position, _enemySpeed * Time.deltaTime);

		if(Vector2.Distance(transform.position, _waypoints[_randomSpot].position) < 0.1) {
			if(_standbyTime <= 0) {
				_randomSpot = Random.Range(0, _waypoints.Length);
				_standbyTime = _startWaitTime; 
			} else {
				_standbyTime -= Time.deltaTime;
			}
		}
	}
}
