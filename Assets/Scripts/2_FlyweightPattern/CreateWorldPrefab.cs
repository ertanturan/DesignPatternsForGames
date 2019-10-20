using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWorldPrefab : MonoBehaviour
{
    public int Width;
    public int Depth;
    public GameObject Cube;

    private void Start()
    {
        for (int i = 0; i < Width; i++)
        {
            for (int j = 0; j < Depth; j++)
            {
                Vector3 pos = new Vector3(i,
                    Mathf.PerlinNoise(i*.2f,j*.2f)*3
                    ,j);
                GameObject obj = Instantiate(Cube, pos, Quaternion.identity);
            }
        }
    }

    private void Update()
    {
        
    }
}
