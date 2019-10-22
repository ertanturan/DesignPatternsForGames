using Unity.Entities;


public struct Spawner : IComponentData
{
    public Entity Prefab;
    public int ERows;
    public int ECols;
}
