using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    private Fader fader;

    private void Start()
    {
        fader = FindObjectOfType<Fader>();
    }

    public void NewGame()
    {
        print("x");
        PlayerPrefs.SetInt("People", 50);
        PlayerPrefs.SetInt("Nature", 50);
        PlayerPrefs.SetInt("Industry", 50);
        PlayerPrefs.SetInt("Science", 50);
        PlayerPrefs.SetInt("DaysSurvived", 0);
        fader.LoadScene(2);
    }

    public void LoadGame()
    {
        fader.LoadScene(2);
    }
}
