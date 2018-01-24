using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour {

	public void LoadNextLevel() {
		int nextLevelNum = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(nextLevelNum);
	}

	public void LoadLevel(int lvl){
		SceneManager.LoadSceneAsync(lvl);
	}

	public void LoadLastLevel() {
		int lastLevelNum = SceneManager.GetActiveScene().buildIndex - 1;
		SceneManager.LoadSceneAsync(lastLevelNum);
	}
}
