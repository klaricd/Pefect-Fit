using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

	public Text HighScore;

	// Use this for initialization
	void Start ()
	{
		HighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
	}
}
