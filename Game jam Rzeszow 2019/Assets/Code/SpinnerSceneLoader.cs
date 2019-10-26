using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinnerSceneLoader : MonoBehaviour
{
    private CurrentEvent currEvent;

    private void Start()
    {
        currEvent = FindObjectOfType<CurrentEvent>();
    }

    public void LoadSpinner()
    {
        if(currEvent.WasCurrentEventClicked)
            SceneManager.LoadScene(2);
    }
}
