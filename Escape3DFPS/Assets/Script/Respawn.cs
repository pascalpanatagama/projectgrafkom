using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    PlayerHealth orang;
    Death rspwn;

    public Transform respawnPoint4;
    public Transform respawnPoint3;
    public Transform respawnPoint2;
    public Transform respawnPoint1;

    public bool diLantai4 = false;
    public bool diLantai3 = false;
    public bool diLantai2 = false;
    public bool diLantai1 = false;

    void Start()
    {
        orang = FindObjectOfType<PlayerHealth>();
        rspwn = FindObjectOfType<Death>();
    }

    void Update()
    {
        if (rspwn.mauRespawn)
        {
            respawnPlayer();
            rspwn.mauRespawn = false;
        }
            
    }

    private void respawnPlayer()
    {
        if (diLantai4)
        {
            transform.position = respawnPoint4.position;
            orang.hitPoints = 100f;
        }
        else if (diLantai3)
        {
            transform.position = respawnPoint3.position;
            orang.hitPoints = 100f;
        }
        else if (diLantai2)
        {
            transform.position = respawnPoint2.position;
            orang.hitPoints = 100f;
        }
        else if (diLantai1)
        {
            transform.position = respawnPoint1.position;
            orang.hitPoints = 100f;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Floor4")
        {
            diLantai4 = true;
            diLantai3 = false;
            diLantai2 = false;
            diLantai1 = false;
        }
        else if (collisionInfo.collider.name == "Floor3")
        {
            diLantai4 = false;
            diLantai3 = true;
            diLantai2 = false;
            diLantai1 = false;
        }
        else if (collisionInfo.collider.name == "Floor2")
        {
            diLantai4 = false;
            diLantai3 = false;
            diLantai2 = true;
            diLantai1 = false;
        }
        else if (collisionInfo.collider.name == "Floor1")
        {
            diLantai4 = false;
            diLantai3 = false;
            diLantai2 = false;
            diLantai1 = true;
        }
    }
}
