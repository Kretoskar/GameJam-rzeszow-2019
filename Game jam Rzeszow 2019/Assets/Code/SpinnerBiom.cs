using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerBiom : MonoBehaviour
{
    [SerializeField]
    private EventType biomType;

    public EventType BiomType { get => biomType; set => biomType = value; }
}
