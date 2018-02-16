using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour {

	public float mvSpeed = 100f;
	public GameObject menu;
	public GameObject menutext;

	private bool move = true;
	private int hold = 10;


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
			if(Input.GetKey(KeyCode.Q))
				transform.position -= transform.up * mvSpeed * Time.deltaTime;
			if(Input.GetKey(KeyCode.E))
				transform.position += transform.up * mvSpeed * Time.deltaTime;	
		}

		if(Input.GetKey(KeyCode.Escape) && hold==10){
			update_inventory();
			move = !move;
			pause();
			hold = 0;
		}

		if(hold < 10){
			hold++;
		}

	}

	void pause(){
		menu.SetActive(!move);
	}

	void update_inventory(){
		if(LevelManager.balls == 0){
			menutext.GetComponent<UnityEngine.UI.Text>().text = "You have nothing in your inventory.";
		}else{
			menutext.GetComponent<UnityEngine.UI.Text>().text = "Balls " + LevelManager.balls.ToString();
		}
	}
}
