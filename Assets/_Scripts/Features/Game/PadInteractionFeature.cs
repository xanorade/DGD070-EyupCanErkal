using UnityEngine;

public class PadInteractionFeature : Feature
{
    private readonly GameContext _gameContext;
    public PadInteractionFeature(Contexts contexts)
    {
        _gameContext = contexts.game;

        Add(new TowerInitializationSystem(_gameContext));
        Add(new TowerCountingSystem(contexts));
        Add(new WinDetectionSystem(contexts));
    }
}