using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour {

	public float mvSpeed = 100f;
	public bool move = true;
	public GameObject menu;

	// Use this for initialization
	void Start () {
		menu.SetActive(!move);
	}

	// Update is called once per frame
	void Update () {
		if(move){
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

		if(Input.GetKey(KeyCode.Escape)){
			move = !move;
			pause();
		}

	}

	void pause(){
		menu.SetActive(!move);
	}
}
