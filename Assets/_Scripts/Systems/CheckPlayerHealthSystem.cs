using Entitas;
using UnityEngine;
public class CheckPlayerHealthSystem : IExecuteSystem
{
    Contexts _contexts;
    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }

    public void Execute()
    { 
        GameEntity[] entities = _contexts.game.GetEntities
            (GameMatcher.AllOf(GameMatcher.PlayerHealth)
                .AnyOf(GameMatcher.PlayerDamaged,GameMatcher.PlayerHealed));
        
        foreach (GameEntity entity in entities)
        {
            float value = entity.playerHealth.value;
            
            if (entity.isPlayerHealed) {
                entity.ReplacePlayerHealth(Mathf.Min(100, entity.playerHealth.value + 10));
                entity.isPlayerHealed = false; 
            }
            
            if (entity.isPlayerDamaged)
            {
                entity.ReplacePlayerHealth(Mathf.Max(0, entity.playerHealth.value - 10));
                entity.isPlayerDamaged = false;
            }
        }
    }
}
