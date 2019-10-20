using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject[] trees;
    public Terrain terrain;

    // Start is called before the first frame update
    void Start()
    {
        PlantTrees();
    }

    void PlantTrees()
    {
        TerrainData terrainData = terrain.terrainData;
        int treeSpacing = 10;
        for (int z = 0; z < terrainData.size.z; z += treeSpacing)
        {
            for (int x = 0; x < terrainData.size.x; x += treeSpacing)
            {
                Vector3 pos = new Vector3(x, 0, z);
                pos.y = terrain.SampleHeight(pos);
                int i = Random.Range(0, trees.Length);
                Instantiate(trees[i], pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
