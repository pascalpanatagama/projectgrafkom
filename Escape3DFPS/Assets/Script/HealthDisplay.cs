using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    PlayerHealth target;
    public Text healthText;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        healthText.text = "HP : " +  target.hitPoints + "/100";  
    
    }
}
