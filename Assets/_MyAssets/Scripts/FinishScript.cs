using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour {

	public GameObject player;
	public GameObject cube;
	public GameObject text;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			text.SetActive(true);
			player.GetComponent<PlayerMovement>().enabled = false;
			cube.GetComponent<PlayerScaling>().enabled = false;
			Debug.Log("Level complete.");
		}
	}
}
