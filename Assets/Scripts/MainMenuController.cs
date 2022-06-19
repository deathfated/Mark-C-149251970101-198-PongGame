using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public string CreditsUrl;
    public GameObject MainCanva;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Mark C - 149251970101-198");
    }

    public void BacktoMain()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Thanks for Playing!");
    }

    public void OpenAuthor()
    {
        Debug.Log("Also, created by Mark C - 149251970101-198");
    }

    public void OpenCredits()
    {
        MainCanva.SetActive(!MainCanva.activeInHierarchy);    
    }

    public void Link()
    {
        Application.OpenURL(CreditsUrl);
    }
}