using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public Vector3 moveVector;

	public static bool isGameStarted;
	public GameObject startingText;

	void Start()
	{
		isGameStarted = false;
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			isGameStarted = true;
			Destroy(startingText);
		}
	}
}
