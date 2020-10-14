using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetDirAndChange : MonoBehaviour
{
    public int dir;

    public int thisScene;

    bool hasCollided = false;

    private int rand;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && hasCollided == false)
        {
            PlayerPrefs.SetInt("Direction", dir);
            hasCollided = true;
            if(PlayerPrefs.GetInt("RoomsDone") == 5 || PlayerPrefs.GetInt("RoomsDone") == 15 || PlayerPrefs.GetInt("RoomsDone") == 20 || PlayerPrefs.GetInt("RoomsDone") == 25)
            {
                PlayerPrefs.SetInt("RoomsDone", 0);
                SwitchTut();
            }
            else
            {
                RandScene();
            }
        }
    }

    void RandScene()
    {
        rand = Random.Range(2, 14);
        if(rand == thisScene || PlayerPrefs.GetInt("LastRand") == rand || rand == 2)
        {
            RandScene();
        }
            switch(rand)
            {
                case 8:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch1();
                break;

                case 9:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                SwitchTut();
                break;

                case 3:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch2();
                break;

                case 4:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch3();
                break;

                case 5:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch1();
                break;

                case 6:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch2();
                break;

                case 7:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch3();
                break;

                case 11:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch1();
                break;

                case 12:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch2();
                break;

                case 13:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                Switch3();
                break;

                case 10:
                NewRoomsDone();
                PlayerPrefs.SetInt("LastRand", rand);
                SwitchTut();
                break;

            }
    }

    void NewRoomsDone()
    {
        int otherRoomsDone = PlayerPrefs.GetInt("RoomsDone");
        int newRoomsDone = otherRoomsDone + 1;
        PlayerPrefs.SetInt("RoomsDone", newRoomsDone);
    }

    void SwitchTut()
    {
        int localdir;
        localdir = PlayerPrefs.GetInt("Direction");
        switch(localdir)
        {
            case 1:
            SceneManager.LoadScene("TutorialRight");
            break;

            case 2:
            SceneManager.LoadScene("TutorialLeft");
            break;

            case 3:
            SceneManager.LoadScene("TutorialUp");
            break;

            case 4:
            SceneManager.LoadScene("TutorialDown");
            break;
        }
    }

    void Switch1()
    {
        int localdir;
        localdir = PlayerPrefs.GetInt("Direction");
        switch(localdir)
        {
            case 1:
            SceneManager.LoadScene("Area1Right");
            break;

            case 2:
            SceneManager.LoadScene("Area1Left");
            break;

            case 3:
            SceneManager.LoadScene("Area1Up");
            break;

            case 4:
            SceneManager.LoadScene("Area1Down");
            break;
        }
    }

    void Switch2()
    {
        int localdir;
        localdir = PlayerPrefs.GetInt("Direction");
        switch(localdir)
        {
            case 1:
            SceneManager.LoadScene("Area2Right");
            break;

            case 2:
            SceneManager.LoadScene("Area2Left");
            break;

            case 3:
            SceneManager.LoadScene("Area2Up");
            break;

            case 4:
            SceneManager.LoadScene("Area2Down");
            break;
        }
    }

    void Switch3()
    {
        int localdir;
        localdir = PlayerPrefs.GetInt("Direction");
        switch(localdir)
        {
            case 1:
            SceneManager.LoadScene("Area3Right");
            break;

            case 2:
            SceneManager.LoadScene("Area3Left");
            break;

            case 3:
            SceneManager.LoadScene("Area3Up");
            break;

            case 4:
            SceneManager.LoadScene("Area3Down");
            break;
        }
    }
}
