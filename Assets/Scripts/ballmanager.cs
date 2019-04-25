using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmanager : MonoBehaviour {

    private List<Transform> balls = new List<Transform>();
    private Transform ballHolder;

	// Use this for initialization
	void Start () {
        ballHolder = GameObject.Find("Balls").GetComponent<Transform>();
        foreach (Transform ball in ballHolder)
        {
            balls.Add(ball);
        }
	}
	
	// Update is called once per frame
	void Update () {
        foreach (Transform ball in balls)
        {
            if (ball.transform.position.y < 0.0f)
            {
                ball.SetPositionAndRotation(new Vector3(-0.00999999f, 0.407f, 4.17f), Quaternion.identity);
            }
        }
	}
}
