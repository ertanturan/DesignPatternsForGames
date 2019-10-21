using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private PlantData _info;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerChecker(other.gameObject))
        {
            SetPlantInfo.Instance.SetInfo(_info);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (LayerChecker(other.gameObject))
        {
            SetPlantInfo.Instance.SetInfo(_info);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (LayerChecker(other.gameObject))
        {
            SetPlantInfo.Instance.CleanInfo();
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (LayerChecker(other.gameObject))
        {
            SetPlantInfo.Instance.CleanInfo();
        }
    }

    private bool LayerChecker(GameObject other)
    {
        if (other.layer == LayerMask.NameToLayer("Player"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
