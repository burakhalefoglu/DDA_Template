
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Server : MonoBehaviour
{
    AskingServerDifficultyLevel askingServerDifficultyLevel;

    String Host = "168.63.24.185";
    Int32 Port = 6060;

    TcpClient mySocket;
    NetworkStream theStream;
    StreamWriter theWriter;
    float time;


    private void Start()
    {
        askingServerDifficultyLevel = GetComponent<AskingServerDifficultyLevel>();
        askingServerDifficultyLevel.ConnectServer(0);

    }

    //void Start()
    //{
    //    mySocket = new TcpClient();
    //    askingServerDifficultyLevel = GetComponent<AskingServerDifficultyLevel>();

    //    if (SetupSocket())
    //    {
    //        Debug.Log("socket is set up");
    //    }
    //}


    //void Update()
    //{
    //    time += Time.deltaTime;

    //    if (!mySocket.Connected)
    //    {
    //        SetupSocket();
    //    }
    //}

    //public bool SetupSocket()
    //{
    //    try
    //    {
    //        //Send Data
    //        mySocket.Connect(Host, Port);
    //        theStream = mySocket.GetStream();
    //        theWriter = new StreamWriter(theStream);
    //        Byte[] sendBytes = System.Text.Encoding.UTF8.GetBytes("yah!! it works");
    //        mySocket.GetStream().Write(sendBytes, 0, sendBytes.Length);
    //        Debug.Log("socket is sent");


    //        //Receive data
    //        byte[] myReadBuffer = new byte[1024];
    //        int numberOfByte = theStream.Read(myReadBuffer, 0, myReadBuffer.Length);
    //        int difficulty = int.Parse(Encoding.ASCII.GetString(myReadBuffer, 0, numberOfByte));
    //        askingServerDifficultyLevel.ConnectServer(difficulty);



    //        return true;
    //    }
    //    catch (Exception e)
    //    {
    //        Debug.Log("Socket error: " + e);
    //        return false;
    //    }
    //}


    //private void OnApplicationQuit()
    //{
    //    if (mySocket != null && mySocket.Connected)
    //        mySocket.Close();
    //}

}

