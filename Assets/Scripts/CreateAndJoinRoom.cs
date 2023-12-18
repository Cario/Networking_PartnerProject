using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using Photon.Pun.Demo.Cockpit;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{

    public TMP_InputField joinInputField;
    public TMP_InputField createInputField;

    public int maxPlayers = 2;

    
    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();

        roomOptions.MaxPlayers = maxPlayers;

        //PhotonNetwork.CreateRoom(createInput.text);
        string roomName = createInputField.GetComponent<TMP_InputField>().text;
        PhotonNetwork.CreateRoom(roomName, roomOptions);
    }

    public void JoinRoom()
    {
        //PhotonNetwork.JoinRoom(joinInput.text);
        string roomName = joinInputField.GetComponent<TMP_InputField>().text;
        PhotonNetwork.JoinRoom(roomName);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
