using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static float _score;
	public float _points;
	public float _lives;
	public GameObject _spawnPoint;
	public PlayerControls _pc;
	private Vector3 _playerStartPoint;

	public static GameManager Instance { get { return m_instance; } }
	private static GameManager m_instance = null;

	
	void Awake() {
		if (m_instance != null && m_instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			m_instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {
		_playerStartPoint = _pc.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CheckSpawn() {
		StartCoroutine("CheckSpawnCor");
	}

	public IEnumerator CheckSpawnCor() {
		_pc.gameObject.SetActive(false);
		yield return new WaitForSeconds(1.0f);
		
		_pc.transform.position = _playerStartPoint;
		_pc.gameObject.SetActive(true);

		_score = 0;
	}
}
