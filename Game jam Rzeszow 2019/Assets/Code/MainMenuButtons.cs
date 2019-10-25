using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void NewGame()
    {
        PlayerPrefs.SetInt("People", 50);
        PlayerPrefs.SetInt("Nature", 50);
        PlayerPrefs.SetInt("Industry", 50);
        PlayerPrefs.SetInt("Science", 50);
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }
}
