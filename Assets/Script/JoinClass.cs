using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JoinClass : MonoBehaviourPunCallbacks
{
    public TMP_InputField input_join;
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(input_join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("client_chat");
    }
}
