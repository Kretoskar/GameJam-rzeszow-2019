using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpinnerSceneLoader : MonoBehaviour
{
    private CurrentEvent currEvent;
    private Variables vars;
    private Fader fader;

    private void Start()
    {
        fader = FindObjectOfType<Fader>();
        vars = FindObjectOfType<Variables>();
        currEvent = FindObjectOfType<CurrentEvent>();
    }

    public void LoadSpinner()
    {
        if (!vars.IsDead)
            if (currEvent.WasCurrentEventClicked)
                fader.LoadScene(2);
    }
}
