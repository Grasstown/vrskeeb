using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getchild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.GetChild(0).GetComponent<Renderer>().material.color = Color.red;
        Debug.Log(this.gameObject.transform.GetChild(0).name);
        this.gameObject.transform.GetChild(1).GetComponent<Renderer>().material.color = Color.clear;
        Debug.Log(this.gameObject.transform.GetChild(1).name);
    }
}
