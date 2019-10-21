using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] private PlantData _info;

    private void OnTriggerEnter(Collider other)
    {

        SetInfoOnLayer(other.gameObject);
    }

    private void OnCollisionEnter(Collision other)
    {
        SetInfoOnLayer(other.gameObject);
    }

    private void SetInfoOnLayer(GameObject other)
    {
        if (LayerChecker(other.gameObject))
        {
            SetPlantInfo.Instance.SetInfo(_info);
            TriggerOnThreat();
        }

    }

    private void TriggerOnThreat()
    {
        if (_info.Threat == THREAT.High)
        {
            PlayerController.dead = true;
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
