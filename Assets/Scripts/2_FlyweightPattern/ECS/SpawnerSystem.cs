using Unity.Burst;
using Unity.Entities;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;


public class SpawnerSystem : JobComponentSystem
{
    private EndSimulationEntityCommandBufferSystem m_EntityCommandBufferSystem;

    protected override void OnCreateManager()
    {
        m_EntityCommandBufferSystem = World.GetOrCreateSystem<EndSimulationEntityCommandBufferSystem>();
    }

    struct SpawnJob : IJobForEachWithEntity<Spawner, LocalToWorld>
    {
        public EntityCommandBuffer CommandBuffer;

        public void Execute(Entity entity, int index, [ReadOnly] ref Spawner spawner,
            [ReadOnly] ref LocalToWorld location)
        {
            for (int x = 0; x < spawner.ERows; x++)
            {
                for (int z = 0; z < spawner.ECols; z++)
                {
                    var instance = CommandBuffer.Instantiate(spawner.Prefab);
                    var pos = math.transform(location.Value,
                        new float3(
                            x, noise.cnoise(new float2(x, z) * .21f), z
                        )
                    );

                    CommandBuffer.SetComponent(instance, new Translation { Value = pos });
                }
            }
            CommandBuffer.DestroyEntity(entity);
        }
    }

    protected override JobHandle OnUpdate(JobHandle inputDeps)
    {

        var job = new SpawnJob
        {
            CommandBuffer = m_EntityCommandBufferSystem.CreateCommandBuffer()

        }.ScheduleSingle(this, inputDeps);

        m_EntityCommandBufferSystem.AddJobHandleForProducer(job);

        return job;
    }
}
