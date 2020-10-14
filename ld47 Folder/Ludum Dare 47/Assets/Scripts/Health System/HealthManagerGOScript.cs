using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManagerGOScript : MonoBehaviour
{
    int health;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject deathGO;

    public float timeBeforeInput = 0.5f;

    bool isDed;

    void Start()
    {
        if(PlayerPrefs.GetInt("FirstTimePlaying") == 0)
        {
            PlayerPrefs.SetInt("Health", 3);
            PlayerPrefs.SetInt("FirstTimePlaying", 1);
        }
        SetHealth();
    }

    void Update()
    {
        if(isDed == true)
        {
            timeBeforeInput -= Time.deltaTime * 1000f;
            if (Input.GetKeyDown("r"))
            {
                PlayerPrefs.SetInt("Direction", 0);
                PlayerPrefs.SetInt("Health", 3);
                PlayerPrefs.SetInt("Gold", 0);
                PlayerPrefs.SetInt("RoomsDone", 0);
                PlayerPrefs.SetInt("LastRand", 8);
                Time.timeScale = 1f;
                SceneManager.LoadScene("Tutorial");
            }
        }
    }

    public void SetHealth()
    {
        health = PlayerPrefs.GetInt("Health");

        switch(health)
        {
            case 0:
            isDed = true;
            Time.timeScale = 0.001f;
            DisableGO(heart1);
            DisableGO(heart2);
            DisableGO(heart3);
            deathGO.SetActive(true);

            break;

            case 1:
            DisableGO(heart2);
            DisableGO(heart3);
            break;

            case 2:
            DisableGO(heart3);
            break;

            case 3:
            break;
        }
    }

    void DisableGO(GameObject disabledGO)
    {
        disabledGO.SetActive(false);
    }
}
