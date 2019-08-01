using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class NManager : MonoBehaviourPunCallbacks {

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings();
	}

    public override void OnConnectedToMaster()
    {
        Debug.Log("We are connected!");
    }

    public void JoinMe()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CreateMe();
        Debug.Log("Failed to join room");
    }

    public void CreateMe()
    {
        PhotonNetwork.AutomaticallySyncScene = true;

        RoomOptions ro = new RoomOptions { MaxPlayers = 10, IsOpen = true, IsVisible = true };

        PhotonNetwork.CreateRoom("defaultRoom", ro, TypedLobby.Default);
    }
}
