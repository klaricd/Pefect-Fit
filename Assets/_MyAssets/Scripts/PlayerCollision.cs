using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public GameObject player;
	public GameObject cube;
	public GameObject text;

	void OnTriggerEnter(Collider other)
	{
		text.SetActive(true);
		player.GetComponent<PlayerMovement>().enabled = false;
		cube.GetComponent<PlayerScaling>().enabled = false;
		Debug.Log("Game over....");
	}
}
