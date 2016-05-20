using UnityEngine;
using System.Collections;
using SocketIO;

public class NetworkMove : MonoBehaviour
{

    public SocketIOComponent socket;

    public void OnMove(Vector3 position)
    {
        Debug.Log("Sending pos to node: " + position);
        socket.Emit("move");
    }
}
