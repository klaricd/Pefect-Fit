using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	[SerializeField] Transform Player;
	[SerializeField] Transform EndLine;
	[SerializeField] Slider slider;

	float maxDistance;


	// Use this for initialization
	void Start ()
	{
		maxDistance = getDistance();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Player.position.z <= maxDistance && Player.position.z <= EndLine.position.z)
		{
			float distance = 1 - (getDistance() / maxDistance);
			setProgress(distance);
		}
	}

	float getDistance()
	{
		return Vector3.Distance(Player.position, EndLine.position);
	}

	void setProgress(float p)
	{
		slider.value = p;
	}
}
