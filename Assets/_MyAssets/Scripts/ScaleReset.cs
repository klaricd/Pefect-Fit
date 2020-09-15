using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleReset : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider other)
	{
		StartCoroutine(ScaleOverTime(.25f));
		player.GetComponent<PlayerScaling>().enabled = true;
	}

	IEnumerator ScaleOverTime(float time)
	{
		Vector3 originalScale = player.transform.localScale;
		Vector3 destinationScale = new Vector3(4f, 2f, .8f);

		float currTime = 0.0f;

		do
		{
			player.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currTime / time);
			currTime += Time.deltaTime;
			yield return null;
		}
		while (currTime <= time);
	}
}
