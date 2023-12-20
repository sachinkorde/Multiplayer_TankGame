using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Unity.Netcode;

public class JoinNetwork : MonoBehaviour
{
    public void JoinNetWork()
    {
        NetworkManager.Singleton.StartClient();
    }
}
