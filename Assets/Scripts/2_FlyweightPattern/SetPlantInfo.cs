using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetPlantInfo : MonoBehaviour
{
    public static SetPlantInfo Instance;

    public GameObject PlantInfoPanel;
    public RawImage PlantIcon;
    public Text PlaneName;
    public Text ThreatLevel;

    private void Awake()
    {
        Instance = this;
    }

    public void OpenPlantPanel()
    {
        PlantInfoPanel.SetActive(true);
    }

    public void ClosePlantPanel()
    {
        PlantInfoPanel.SetActive(false);
    }

    public void SetInfo(PlantData info)
    {
        PlaneName.text = info.PlantName;
        ThreatLevel.text = info.Threat.ToString();
        PlantIcon.texture = info.Icon;
    }

    public void CleanInfo()
    {
        PlaneName.text = "";
        ThreatLevel.text = "";
        PlantIcon.texture = null;
    }

}
