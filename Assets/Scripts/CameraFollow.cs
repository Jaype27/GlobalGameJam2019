using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform _player;
	public float smoothTime = 0.15f;
	Vector3 velocity = Vector3.zero;

	public bool YmaxBool = false;
	public float YmaxValue = 0;
	public bool YminBool = false;
	public float YminValue = 0;
	public bool XmaxBool = false;
	public float XmaxValue = 0;
	public bool XminBool = false;
	public float XminValue = 0;
	
	void Update () {

	}
	
	void FixedUpdate () {
		
		if(GameObject.Find("Player") != null) {
			_player = GameObject.Find("Player").transform;
		}

		if(_player == null)
		return;
		
		Vector3 _playerPos = _player.position;

		if (YminBool && YmaxBool) 
			_playerPos.y = Mathf.Clamp(_player.position.y, YminValue, YmaxValue);
		
		else if (YminBool) 
			_playerPos.y = Mathf.Clamp(_player.position.y, YminValue, _player.position.y);

		else if (YmaxBool)
			_playerPos.y = Mathf.Clamp(_player.position.y, _player.position.y, YmaxValue);


		if (XminBool && XmaxBool)
			_playerPos.x = Mathf.Clamp(_player.position.x, XminValue, XmaxValue);
		
		else if (XminBool)
			_playerPos.x = Mathf.Clamp(_player.position.x, XminValue, _player.position.x);

		else if (XmaxBool) 
			_playerPos.x = Mathf.Clamp(_player.position.x, _player.position.x, XmaxValue);
		
		_playerPos.z = transform.position.z;

		transform.position = Vector3.SmoothDamp(transform.position, _playerPos, ref velocity, smoothTime);

	}
}
