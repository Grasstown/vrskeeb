using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tenpt : MonoBehaviour {

    private int score;
    private Text scoreText;

	// Use this for initialization
	void Start () {
        scoreText = GameObject.Find("Text").GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        setScore();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            Debug.Log("10 pts");
            score += 10;
        }
    }

    void setScore() {
        scoreText.text = "Score: " + score;
    }
}
