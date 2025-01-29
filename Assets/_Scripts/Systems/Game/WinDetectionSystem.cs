using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class WinDetectionSystem : ReactiveSystem<GameEntity>
{
    private readonly GameContext _gameContext;
    
    public WinDetectionSystem(Contexts contexts): base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return null;
    }

    protected override bool Filter(GameEntity entity)
    {
        throw new System.NotImplementedException();
    }

    protected override void Execute(List<GameEntity> entities)
    {
        throw new System.NotImplementedException();
    }
}
