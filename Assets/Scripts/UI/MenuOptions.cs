using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {

    public void Create()
    {
        SceneManager.LoadSceneAsync("RegisterScene", LoadSceneMode.Additive);
    }

    public void Login()
    {
        SceneManager.LoadSceneAsync("LoginScene", LoadSceneMode.Additive);
    }
}
