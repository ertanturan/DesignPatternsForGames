using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetPlantInfo : MonoBehaviour
{
    [FormerlySerializedAs("plantInfoPanel")] public GameObject PlantInfoPanel;
    [FormerlySerializedAs("plantIcon")] public GameObject PlantIcon;
    public Text PlaneName;
    public Text ThreatLevel;



    public void OpenPlantPanel()
    {
        PlantInfoPanel.SetActive(true);
    }

    public void ClosePlantPanel()
    {
        PlantInfoPanel.SetActive(false);
    }
}
