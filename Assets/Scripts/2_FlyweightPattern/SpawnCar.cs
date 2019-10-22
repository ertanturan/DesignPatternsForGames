using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCar : MonoBehaviour
{
    public GameObject Car;

    public GameObject Camera;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = new Vector3(10,10,10);
            GameObject c = Instantiate(Car, pos, Quaternion.identity);
            Camera.GetComponent<SmoothFollow>().target = c.transform;
        }
    }

}
