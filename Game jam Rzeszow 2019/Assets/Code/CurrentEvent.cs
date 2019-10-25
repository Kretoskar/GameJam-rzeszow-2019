using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentEvent : MonoBehaviour
{
    [SerializeField]
    private EventSO currentEvent;

    private Variables variables;

    public EventSO CurrentEventSO
    {
        get
        {
            return currentEvent;
        }
        set
        {
            currentEvent = value;
            WasCurrentEventClicked = false;
        }
    }

    public bool WasCurrentEventClicked = false;

    private void Start()
    {
        variables = FindObjectOfType<Variables>();
    }

    public void AClicked()
    {
        UpdateVars(currentEvent.AToPeople1, currentEvent.AToNature1, currentEvent.AToIndustry1, currentEvent.AToScience1);
    }

    public void BClicked()
    {
        UpdateVars(currentEvent.BToPeople1, currentEvent.BToNature1, currentEvent.BToIndustry1, currentEvent.BToScience1);
    }

    public void CClicked()
    {
        UpdateVars(currentEvent.CToPeople1, currentEvent.CToNature1, currentEvent.CToIndustry1, currentEvent.CToScience1);
    }

    private void UpdateVars(int p, int n, int i, int s)
    {
        if (!WasCurrentEventClicked) {
            variables.People += p;
            variables.Nature += n;
            variables.Industry += i;
            variables.Science += s;
            WasCurrentEventClicked = true;
        }
    }
}
