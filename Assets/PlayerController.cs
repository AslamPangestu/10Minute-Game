using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 600f;
	float movement = 0f;
	public GameObject gameOver;
	// Use this for initialization
	void Start () {
		gameOver.SetActive(false);		
	}
	
	// Update is called once per frame
	void Update () {
		movement = Input.GetAxisRaw("Horizontal");
	}

	private void FixedUpdate() {
		transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -playerSpeed);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		gameOver.SetActive(true);
        Time.timeScale = 0f;
	}

	public void TryAgain(){
		gameOver.SetActive(false);
        Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
