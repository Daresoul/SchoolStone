using UnityEngine;
using System.Collections;
using SocketIO;

public class Network : MonoBehaviour
{

    static SocketIOComponent socket;

    public GameObject playerPrefab;

    void Start()
    {
        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
        socket.On("spawn", OnSpawn);
    }

    void OnConnected(SocketIOEvent e)
    {
        Debug.Log("Connected");
    }

    void OnSpawn(SocketIOEvent e)
    {
        Debug.Log("Spawned");
        Instantiate(playerPrefab);
    }
}
