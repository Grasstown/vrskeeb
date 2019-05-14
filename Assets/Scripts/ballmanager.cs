using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ballmanager : MonoBehaviour {
    
    private Text scoreText;
    private static int score;
    private Vector3 startingPoint;
    public GameObject hands;
    
	// Use this for initialization
	void Start () {
        scoreText = GameObject.FindObjectOfType<Text>();
        score = 0;
        startingPoint = transform.position;
	}

    private void Update()
    {
        scoreText.text = "Score: " + score;
        if (score < 0)
        {
            scoreText.text = "You Lose!";
            hands.SetActive(false);
            MixedRealityTeleport.Instance.EnableTeleport = false;
            MixedRealityTeleport.Instance.EnableRotation = false;
            MixedRealityTeleport.Instance.EnableStrafe = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "10":
                score += 10;
                gameObject.SetActive(false);
                break;
            case "50":
                score += 50;
                gameObject.SetActive(false);
                break;
            case "100":
                score += 100;
                gameObject.SetActive(false);
                break;
            default:
                break;
        }
    }

    void FixedUpdate () {
        if (gameObject.transform.position.y < -0.5)
        {
            score -= 10;
            gameObject.SetActive(false);
            gameObject.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.GetComponent<Transform>().SetPositionAndRotation(startingPoint, Quaternion.identity);
            gameObject.SetActive(true);
        }
    }
}