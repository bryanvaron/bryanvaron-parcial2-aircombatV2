using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adelante : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector3.right * Time.deltaTime * 200);
		Destroy (gameObject, 5);
		
	}
}
