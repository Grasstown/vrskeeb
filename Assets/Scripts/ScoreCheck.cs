using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCheck : MonoBehaviour {

    public Text scoreUI;

    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        SetScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("100"))
        {
            score += 100;
        }
        else if (other.tag.Equals("50"))
        {
            score += 50;
        }
        else if (other.CompareTag("10"))
        {
            score += 10;
        }
    }

    void SetScore()
    {
        scoreUI.text = "Score: " + score.ToString();
    }
}
