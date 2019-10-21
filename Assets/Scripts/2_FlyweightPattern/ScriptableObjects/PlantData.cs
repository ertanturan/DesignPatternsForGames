using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Plant Data",
    menuName = "The Flyweight Pattern/Plant Data", order = 51)]
public class PlantData : ScriptableObject
{

    [SerializeField] private string plantName;
    [SerializeField] private THREAT plantThreat;
    [SerializeField] private Texture Icon;
}
