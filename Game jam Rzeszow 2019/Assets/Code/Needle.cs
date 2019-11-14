using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Needle : MonoBehaviour
{
    private Spinner spinner;
    private Fader fader;

    private void Start()
    {
        fader = FindObjectOfType<Fader>();
        spinner = FindObjectOfType<Spinner>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!spinner.IsStoped)
            return;
        FindObjectOfType<EventToLoad>().SetEventToLoad(collision.gameObject.GetComponent<SpinnerBiom>().BiomType);
        fader.LoadScene(1);
    }
}
