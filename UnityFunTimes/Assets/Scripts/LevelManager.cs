using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadNextLevel() {
		int nextLevelNum = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(nextLevelNum);
	}//end LoadNextLevel

	public void LoadScene(int scene){
		SceneManager.LoadScene(scene);
	}
}
