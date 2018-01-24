using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float mvSpeed = 5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;

		if(Input.GetKey(KeyCode.W))
			transform.position += transform.forward * mvSpeed * Time.deltaTime;
		if(Input.GetKey(KeyCode.S))
			transform.position -= transform.forward * mvSpeed * Time.deltaTime;
		if(Input.GetKey(KeyCode.A))
			transform.position -= transform.right * mvSpeed * Time.deltaTime;
		if(Input.GetKey(KeyCode.D))
			transform.position += transform.right * mvSpeed * Time.deltaTime;
	}
}
