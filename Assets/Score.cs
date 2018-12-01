using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public float score;
	public Text scoreTxt,scoreFinalTxt;
	// Use this for initialization
	void Start () {
		score = 0f;
		scoreTxt.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		scoreTxt.text = Mathf.RoundToInt(score).ToString();
		scoreFinalTxt.text = Mathf.RoundToInt(score).ToString();
	}
}
