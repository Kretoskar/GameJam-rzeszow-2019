using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    private Spinner spinner;

    private void Start()
    {
        spinner = FindObjectOfType<Spinner>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!spinner.IsStoped)
            return;
        FindObjectOfType<EventToLoad>().SetEventToLoad(collision.gameObject.GetComponent<SpinnerBiom>().BiomType);
    }
}
