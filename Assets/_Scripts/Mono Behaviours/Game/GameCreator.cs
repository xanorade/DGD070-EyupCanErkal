using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;
    
    private PlayerInputFeature _playerInputFeature;
    private PlayerMovementFeature _playerMovementFeature;
    private PlayerFeature _playerFeature;
    private ViewFeature _viewFeature;
    
    private void Start()
    {
        #region FEATURES
        _playerInputFeature = new PlayerInputFeature(Contexts.sharedInstance);
        _playerMovementFeature = new PlayerMovementFeature(Contexts.sharedInstance);
        _playerFeature = new PlayerFeature(Contexts.sharedInstance);
        _viewFeature = new ViewFeature(Contexts.sharedInstance);
        #endregion
        
        #region INITALIZATION
        _playerInputFeature.Initialize();
        _playerMovementFeature.Initialize();
        _playerFeature.Initialize();
        _viewFeature.Initialize();
        #endregion
    }

    private void Update()
    {
        #region EXECUTION
        _playerInputFeature.Execute();
        _playerMovementFeature.Execute();
        _playerFeature.Execute();
        _viewFeature.Execute();
        #endregion
    }

    private void LateUpdate()
    {
        #region CLEANUP
        _playerInputFeature.Cleanup();
        _playerMovementFeature.Cleanup();
        _playerFeature.Cleanup();
        _viewFeature.Cleanup();
        #endregion
    }
}