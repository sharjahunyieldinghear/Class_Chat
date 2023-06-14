
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class JoinClass : MonoBehaviourPunCallbacks
{
    public TMP_InputField input_join;
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(input_join.text);
        Debug.Log(input_join.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("DID I JOIN THE ROOM?");
        PhotonNetwork.LoadLevel("ClientChat");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
    }
}
