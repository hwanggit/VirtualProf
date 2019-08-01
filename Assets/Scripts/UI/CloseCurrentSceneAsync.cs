using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseCurrentSceneAsync : MonoBehaviour {

	public void CloseScene()
	{
		SceneManager.UnloadSceneAsync("AlertScene");
	}
}
