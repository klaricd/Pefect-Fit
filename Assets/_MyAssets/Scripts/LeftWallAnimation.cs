using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallAnimation : MonoBehaviour {

	[SerializeField] public Animator myAnimationController;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			myAnimationController.SetBool("moveLeftWall", true);
		}
	}
}
