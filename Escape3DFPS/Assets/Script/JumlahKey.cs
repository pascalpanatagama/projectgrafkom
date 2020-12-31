using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumlahKey : MonoBehaviour
{
    public Text sumKey;
    InteractScript jumKey;
    Respawn lantai;

    int key4 = 3;
    int key3 = 2;
    int key2 = 2;
    int key1 = 2;
    void Start()
    {
        jumKey = FindObjectOfType<InteractScript>();
        lantai = FindObjectOfType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lantai.diLantai4)
        {
            sumKey.text = "(" + jumKey.jumlahKey4 + "/" + key4 + ")";
        } else if (lantai.diLantai3)
        {
            sumKey.text = "(" + jumKey.jumlahKey3 + "/" + key3 + ")";
        } else if (lantai.diLantai2)
        {
            sumKey.text = "(" + jumKey.jumlahKey2 + "/" + key2 + ")";
        } else if (lantai.diLantai1)
        {
            sumKey.text = "(" + jumKey.jumlahKey1 + "/" + key1 + ")";
        }
    }
}
