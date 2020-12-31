using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    PlayerHealth orang;

    public GameObject DeathUI;
    public bool mauRespawn = false;

    void Start()
    {
        orang = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        if (orang.hitPoints <= 0)
        {
            DeathUI.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void respawn()
    {
        DeathUI.SetActive(false);
        Time.timeScale = 1f;
        mauRespawn = true;
    }
}
