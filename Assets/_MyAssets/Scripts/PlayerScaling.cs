using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaling : MonoBehaviour {

	public GameObject player;
	public float speed = 5f;
	Vector3 temporary;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			temporary = transform.localScale;
			temporary.x -= Time.deltaTime + .015f;
			transform.localScale = temporary;

			if(temporary.x < .25)
			{
				player.GetComponent<PlayerScaling>().enabled = false;
			}
		}
	}
}
