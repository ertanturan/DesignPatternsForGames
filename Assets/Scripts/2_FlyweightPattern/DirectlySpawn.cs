using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectlySpawn : MonoBehaviour
{
    public GameObject Cube;
    public int Rows;
    public int Cols;

    private void Start()
    {
        for (int x = 0; x < Rows; x++)
        {
            for (int z = 0; z < Cols; z++)
            {
                Vector3 pos = new Vector3(x,
                    Mathf.PerlinNoise(x * .21f, z * .21f)
                    , z);
                GameObject.Instantiate(Cube, pos, Quaternion.identity);
            }
        }
    }
}
