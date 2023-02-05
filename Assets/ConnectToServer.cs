using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    private void Start() {
        PhotonNetwork.ConnectUsingSettings();
    }
    private void OnConnectedToServer() {
        
        print("Connected to Server");
        PhotonNetwork.JoinLobby();
    }
    
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
