using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Alerts : MonoBehaviour {

	public IEnumerator CreateNewAlert(string msg) {
		yield return SceneManager.LoadSceneAsync("MasterScene");
		GameObject.FindObjectOfType<AlertObjects> ().AlertText.text = msg;
	}
}
