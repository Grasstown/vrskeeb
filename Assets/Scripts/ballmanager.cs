using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ballmanager : MonoBehaviour {

    private static Rigidbody rb;
    private Text scoreText;
    private static int score;
    public GameObject hands;
    
	// Use this for initialization
	void Start () {
        scoreText = GameObject.FindObjectOfType<Text>();
        rb = gameObject.GetComponent<Rigidbody>();
        score = 0;
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
                break;
            case "50":
                score += 50;
                break;
            case "100":
                score += 100;
                break;
            default:
                break;
        }
    }

    void FixedUpdate () {
        if (gameObject.transform.position.y < -0.5)
        {
            score -= 10;
            rb.velocity = rb.angularVelocity = Vector3.zero;
            rb.GetComponent<Transform>().SetPositionAndRotation(new Vector3(0.0f, 0.6f, 4.27f), Quaternion.identity);
        }
    }
}