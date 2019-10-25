using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinnerUI : MonoBehaviour
{
    [SerializeField]
    private Text daysSurvivedText;

    private Variables vars;

    private void Start()
    {
        vars = FindObjectOfType<Variables>();
        daysSurvivedText.text = "Days survived: " + vars.DaysSurvived.ToString();
    }
}
