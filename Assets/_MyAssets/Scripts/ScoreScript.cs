using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text currScore;
	public Text finalScore;
	private int score;

	// Use this for initialization
	void Start ()
	{
		currScore.text = "";
		finalScore.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{
		currScore.text = "" + score;
		finalScore.text = "" + score;

		if(score > PlayerPrefs.GetInt("HighScore"))
		{
			PlayerPrefs.SetInt("HighScore", score);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Trigger"))
		{
			score = score + 10;
		}
	}
}
