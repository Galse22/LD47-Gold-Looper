using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadScene(1);
    }

    public void GoToBugScene() 
    {
        SceneManager.LoadScene(18);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
