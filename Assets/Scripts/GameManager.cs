using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[HideInInspector]
	public int _gemAmount;
	[HideInInspector]
	public int _cherryAmount;


	public int _lives;
	public GameObject _spawnPoint;
	public PlayerControls _pc;
	public Text _gemUIText;
	public Text _cherryUIText;
	public Text _livesUIText;
	public GameObject _playerSpawnPoint;

	public GameObject[] _itemList;
	public GameObject[] _itemSpawnList;
	public GameObject _gameOverScreen;

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
		_gemAmount = 0;
		_cherryAmount = 0;
		_lives = 3;
		
	}
	
	// Update is called once per frame
	void Update () {

		_gemUIText.text = "" + _gemAmount;
		_cherryUIText.text = "" + _cherryAmount;
		_livesUIText.text = "Lives: " + _lives;
		
	}

	public void CheckSpawn() {
		StartCoroutine("CheckSpawnCor");
	}

	public IEnumerator CheckSpawnCor() {
		
		if(_lives >= 1) {
			
			_gemAmount = 0;
			_cherryAmount = 0;

			yield return new WaitForSeconds(1.0f);

			_pc.transform.position = _playerSpawnPoint.transform.position;
			_pc.gameObject.SetActive(true);

			_itemList[0].transform.position = _itemSpawnList[0].transform.position;
			_itemList[0].gameObject.SetActive(true);

			_itemList[1].transform.position = _itemSpawnList[1].transform.position;
			_itemList[1].gameObject.SetActive(true);

			_itemList[2].transform.position = _itemSpawnList[2].transform.position;
			_itemList[2].gameObject.SetActive(true);

			_itemList[3].transform.position = _itemSpawnList[3].transform.position;
			_itemList[3].gameObject.SetActive(true);

			_itemList[4].transform.position = _itemSpawnList[4].transform.position;
			_itemList[4].gameObject.SetActive(true);
		
			_itemList[5].transform.position = _itemSpawnList[5].transform.position;
			_itemList[5].gameObject.SetActive(true);

			_itemList[6].transform.position = _itemSpawnList[6].transform.position;
			_itemList[6].gameObject.SetActive(true);

			_itemList[7].transform.position = _itemSpawnList[7].transform.position;
			_itemList[7].gameObject.SetActive(true);

			_itemList[8].transform.position = _itemSpawnList[8].transform.position;
			_itemList[8].gameObject.SetActive(true);

			_itemList[9].transform.position = _itemSpawnList[9].transform.position;
			_itemList[9].gameObject.SetActive(true);

			_itemList[10].transform.position = _itemSpawnList[10].transform.position;
			_itemList[10].gameObject.SetActive(true);
		
		} else if (_lives < 1) {

			Debug.Log("Game Over");
			_gameOverScreen.gameObject.SetActive(true);
		}
	}
}
