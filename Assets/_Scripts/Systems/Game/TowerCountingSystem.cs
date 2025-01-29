using Entitas;
using UnityEngine;

public class TowerCountingSystem : IExecuteSystem
{
    private readonly GameContext _gameContext;
    private int _numberOfTowers;
    private bool _allTowersDestroyed;

    public TowerCountingSystem(GameContext gameContext)
    {
        _gameContext = gameContext;
        _numberOfTowers = ReferenceCatalog.Instance.towerReferences.Length;
    }

    public void Execute()
    {
        GameEntity[] destroyedTowers = _gameContext.GetEntities(GameMatcher.TowerDestroyed);
        if (destroyedTowers.Length >= _numberOfTowers && !_allTowersDestroyed)
        {
            _allTowersDestroyed = true;
            _gameContext.isAllTowersDestroyed = true;
        }
    }
}