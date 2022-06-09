using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

        public void PlayGame()
        {
            SceneManager.LoadScene("Game");
            Debug.Log("Created by Mark C - 149251970101-198");
        }

        public void OpenAuthor()
        {
            Debug.Log("Also created by Mark C - 149251970101-198");
        }
    }