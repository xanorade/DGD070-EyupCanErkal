using Entitas;
public class CreatePlayerHealthSystem : IInitializeSystem 
{
    private GameContext _context; 
    public CreatePlayerHealthSystem(Contexts contexts) {
        _context = contexts.game;
    }
   
    public void Initialize() {
        var player = _context.CreateEntity();
        player.AddPlayerHealth(100f);
    }
}