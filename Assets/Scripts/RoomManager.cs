using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using System;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    private float minX, maxX, minZ, maxZ;

    void Start()
    {
        minX = -5.0f;
        minZ = -5.0f;
        maxX = 5.0f;
        maxZ = 5.0f;

        Vector3 randSpawnPoint = new Vector3(UnityEngine.Random.Range(minX, maxX), 0.35f, UnityEngine.Random.Range(minZ, maxZ));

        GameObject _player = PhotonNetwork.Instantiate(player.name, randSpawnPoint, Quaternion.identity);
    }
}