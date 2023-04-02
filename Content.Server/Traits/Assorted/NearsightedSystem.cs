using Content.Server.GameTicking;
using Content.Shared.Traits.Assorted;

namespace Content.Server.Traits.Assorted;

public sealed class NearsightedSystem : SharedNearsightedSystem
{
    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PlayerSpawnCompleteEvent>(OnPlayerSpawn);
    }


    private void OnPlayerSpawn(PlayerSpawnCompleteEvent args)
    {
        foreach (var comp in EntityQuery<NearsightedComponent>())
        {

        }
    }
}
