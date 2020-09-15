using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

	GameManager gameManager;

	// Use this for initialization
	void Start () 
	{
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		gameManager = gameController.GetComponent<GameManager>();
	}

	// Update is called once per frame
	void Update()
	{
		if (!GameManager.isGameStarted)
		{
			return;
		}

		transform.Translate(gameManager.moveVector * gameManager.moveSpeed * Time.deltaTime);
	}
}
