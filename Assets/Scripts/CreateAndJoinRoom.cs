using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{

    public TMP_InputField joinInputField;
    public TMP_InputField createInputField;

    public void CreateRoom()
    {
        //PhotonNetwork.CreateRoom(createInput.text);
        string roomName = createInputField.GetComponent<TMP_InputField>().text;
        PhotonNetwork.CreateRoom(roomName);
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
