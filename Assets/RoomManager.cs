using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    [Space]
    public GameObject spawnPoint;

    void Start()
    {
        Debug.Log("Connecting to Server...");

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();

        Debug.Log("Successfully Connected to Server");

        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        Debug.Log("Joined Lobby");

        PhotonNetwork.JoinOrCreateRoom("Test", null, null);

    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        Debug.Log("Joined Room");

        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.transform.position, Quaternion.identity);
    }
}
