using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class SpawnProxy : MonoBehaviour, IDeclareReferencedPrefabs, IConvertGameObjectToEntity
{

    public GameObject Cube;
    public int Rows;
    public int Cols;

    public void DeclareReferencedPrefabs(List<GameObject> list)
    {
        list.Add(Cube);
    }

    public void Convert(Entity entity, EntityManager manager,
        GameObjectConversionSystem conversionSystem)
    {
        var spawnerData = new Spawner
        {
            Prefab = conversionSystem.GetPrimaryEntity(Cube),
            ERows = Rows,
            ECols = Cols,
        };
            manager.AddComponentData(entity,spawnerData);

    }


}


