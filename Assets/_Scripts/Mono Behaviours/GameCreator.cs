using UnityEngine;
public class GameCreator : MonoBehaviour
{ 
    private Contexts _contexts;
    private PlayerHealthFeature _playerHealthFeature;
    void Start()
    {
        _contexts = Contexts.sharedInstance;
        
        _playerHealthFeature = new PlayerHealthFeature(_contexts);
       
       _playerHealthFeature.Initialize();
    }
    private void Update()
    {
        _playerHealthFeature.Execute();
    }
}
