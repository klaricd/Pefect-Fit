using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFall : MonoBehaviour {

	public GameObject animatorL;
	public GameObject animatorR;
	public GameObject player;
	public GameObject cam;
	public GameObject text;

	void OnTriggerEnter(Collider other)
	{
		animatorL.GetComponent<Animator>().enabled = false;
		animatorR.GetComponent<Animator>().enabled = false;
		player.GetComponent<PlayerMovement>().enabled = false;
		cam.GetComponent<CameraFollow>().enabled = false;
		text.SetActive(true);
	}
}
