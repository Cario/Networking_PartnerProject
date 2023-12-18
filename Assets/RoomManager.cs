using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    private float minX, maxX, minZ, maxZ;

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

        minX = -5.0f;
        minZ = -5.0f;
        maxX = 5.0f;
        maxZ = 5.0f;

        Vector3 randSpawnPoint = new Vector3(UnityEngine.Random.Range(minX, maxX), 0.35f, UnityEngine.Random.Range(minZ, maxZ));

        GameObject _player = PhotonNetwork.Instantiate(player.name, randSpawnPoint, Quaternion.identity);
    }
}