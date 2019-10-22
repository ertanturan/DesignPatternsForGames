using System;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;


[RequiresEntityConversion]
public class PerlinPositionProxy : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager manager,
        GameObjectConversionSystem conversionSystem)
    {

        PerlinPosition data = new PerlinPosition { };

        manager.AddComponentData(entity, data);

    }

}
