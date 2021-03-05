using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -9);
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
