using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using System;
using System.Linq;

public class StartClass : MonoBehaviourPunCallbacks
{
    public string code { get; private set; }
    public int time { get; private set; }

    public void setTime1()
    {
        time = 50;
    }
    public void setTime2()
    {
        time = 75;
    }
    public void setTime3()
    {
        time = 120;
    }

    public void GenerateRandomCode()
    {
        // Define the characters that you want to use in your random string.
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var random = new System.Random();

        // Generate the 4-letter random string.
        code = new string(Enumerable.Range(1, 4).Select(_ => chars[random.Next(chars.Length)]).ToArray());
    }

    public void CreateRoom()
    {
        GenerateRandomCode();

        PhotonNetwork.CreateRoom(code);
        Debug.Log(code);
        Debug.Log(time);
        PhotonNetwork.JoinRoom(code);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("SampleScene");
    }


}
