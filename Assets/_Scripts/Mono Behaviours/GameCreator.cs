using Entitas;
using UnityEngine;

public class GameCreator : MonoBehaviour
{
   private GameContext _context;
    void Start()
    {
       _context = Contexts.sharedInstance.game;
       
       GameEntity entityOne = _context.CreateEntity();
       entityOne.AddPlayerHealth(500f);
       
    }
    
}
