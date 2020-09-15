using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallAnimation : MonoBehaviour {

	[SerializeField] public Animator myAnimationController;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			myAnimationController.SetBool("moveRightWall", true);
		}
	}
}
