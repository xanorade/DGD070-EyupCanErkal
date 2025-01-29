using Entitas;
using UnityEngine;

public class PlayerMovementSystem : IExecuteSystem
{
    GameContext _gameContext;
    InputContext _inputContext;

    public PlayerMovementSystem(GameContext gameContext, InputContext inputContext) 
    {
        _gameContext = gameContext;
        _inputContext = inputContext;
        
    }
    public void Execute()
    {
        if (_gameContext.playerEntity == null) return;
        GameEntity player = _gameContext.playerEntity;
        
        if(player.isAlive == false) return;
        if(!player.hasPosition) return;
        
        Vector2 input = _inputContext.playerInput.Value;
        Vector3 displacement = new Vector3(input.x, 0, input.y) * (player.speed.Value * Time.deltaTime);
        Vector3 newPosition = player.position.Value + displacement;
        
        player.ReplacePosition(newPosition);
    }
}