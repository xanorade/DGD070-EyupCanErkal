public class PlayerHealthFeature : Feature
{
   Contexts _contexts; 
   public PlayerHealthFeature(Contexts contexts)
   {
      _contexts = contexts;
      Add(new CreatePlayerHealthSystem(contexts));
      Add(new CheckPlayerHealthSystem(contexts));
      Add(new ChangePlayerHealthSystem(contexts));
   }
}
