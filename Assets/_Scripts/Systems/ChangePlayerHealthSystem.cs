using Entitas;
using UnityEngine;
public class ChangePlayerHealthSystem : IExecuteSystem
{
    Contexts _contexts; 
    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _contexts = contexts;
    }
    
    public void Execute()
    {
        GameEntity[] entities = _contexts.game.GetEntities
        (GameMatcher.AllOf(GameMatcher.PlayerHealth));

        foreach (GameEntity entity in entities)
        {
            if (Input.GetKeyDown(KeyCode.D)) 
            { 
                entity.isPlayerDamaged = true; 
            }
        
            if (Input.GetKeyDown(KeyCode.H)) 
            { 
                entity.isPlayerHealed = true; 
            }
        }
    }
}
