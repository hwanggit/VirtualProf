using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Alerts alert = new Alerts ();
		StartCoroutine(alert.CreateNewAlert ("The scene has started!"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
