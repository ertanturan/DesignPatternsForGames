using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject EggPrefab;
    public Terrain Terrain;
    private TerrainData _terrainData;

    private void Start()
    {
        _terrainData = Terrain.terrainData;
        InvokeRepeating("CreateEgg",1,.1f);
    }


    private void CreateEgg()
    {
        int x = (int) Random.Range(0, _terrainData.size.x);
        int z = (int) Random.Range(0, _terrainData.size.z);

        Vector3 pos = new Vector3(x,0,z);
        pos.y = Terrain.SampleHeight(pos) + 10;

        GameObject egg = Instantiate(EggPrefab, pos, Quaternion.identity);
    }

}
