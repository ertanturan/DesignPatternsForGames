using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Plant Data",
    menuName = "The Flyweight Pattern/Plant Data", order = 51)]
public class PlantData : ScriptableObject
{

    [FormerlySerializedAs("plantName")] [SerializeField] private string _plantName;
    [FormerlySerializedAs("plantThreat")] [SerializeField] private THREAT _plantThreat;
    [FormerlySerializedAs("Icon")] [SerializeField] private Texture _icon;

    public string PlantName
    {
        get { return _plantName; }
    }

    public THREAT Threat
    {
        get { return _plantThreat; }
    }

    public Texture Icon
    {
        get { return _icon; }
    }


}
