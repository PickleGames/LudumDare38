using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour {

	public string mainSceneName = null;
	//goes to main game scene
	public void playButtonFunction() {
		SceneManager.LoadScene(mainSceneName);
	}

	//quits game
	public void quitButtonFunction() {
		Application.Quit();
	}


}
