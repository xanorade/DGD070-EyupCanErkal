using Entitas;
using UnityEngine;

public class PlayerCreatorSystem : IInitializeSystem 
{
    private GameContext _gameContext;
    
    private const float PlayerSpeed = 10f;

    public PlayerCreatorSystem(GameContext gameContext)
    {
        _gameContext = gameContext;
    }

    public void Initialize() {
        // Önce eski player'ı temizle
        foreach (var entity in _gameContext.GetEntities(GameMatcher.Player)) {
            entity.Destroy();
        }

        // Yeni player oluştur
        GameEntity player = _gameContext.CreateEntity();
        player.isPlayer = true;
        player.AddPosition(Vector3.zero);
        player.AddSpeed(PlayerSpeed);

        var bottomLeft = new Vector3(-10f, 0f, -10f);
        var topRight = new Vector3(10f, 0f, 10f);
        player.AddBounds(bottomLeft, topRight);
    }
}