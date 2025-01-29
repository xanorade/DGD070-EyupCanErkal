using Entitas;
using UnityEngine;

public class TowerCountingSystem : IExecuteSystem
{
    private readonly GameContext _gameContext;

    public TowerCountingSystem(GameContext gameContext)
    {
        _gameContext = gameContext;
    }

    public void Execute()
    {
       
    }
}
