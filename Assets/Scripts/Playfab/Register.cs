using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour {

    public InputField Username;
    public InputField Password;
    public InputField EmailAdr;

    public void CreateAccount() {
        RegisterPlayFabUserRequest request = new RegisterPlayFabUserRequest();
        request.Username = Username.text;
        request.Password = Password.text;
        request.Email = EmailAdr.text;
        request.DisplayName = Username.text;

        PlayFabClientAPI.RegisterPlayFabUser(request, result => {
            Alerts a = new Alerts();
            StartCoroutine(a.CreateNewAlert(result.Username + " Has been created!"));
            SceneManager.LoadSceneAsync("LoginScene");
        }, error => {
            Alerts a = new Alerts();
            StartCoroutine(a.CreateNewAlert(error.ErrorMessage));
        });
    }
}
