using UnityEngine;

public class GameCreator : MonoBehaviour
{
    private Contexts _contexts;

    #region FEATURES
    private PlayerInputFeature _playerInputFeature;
    private PlayerFeature _playerFeature;
    private PlayerMovementFeature _playerMovementFeature;
    private PadInteractionFeature _padInteractionFeature;
    private ViewFeature _viewFeature;
    #endregion
    
    
    private void Start()
    {
        #region NEW FEATURES
        _playerInputFeature = new PlayerInputFeature(Contexts.sharedInstance);
        _playerFeature = new PlayerFeature(Contexts.sharedInstance);
        _playerMovementFeature = new PlayerMovementFeature(Contexts.sharedInstance);
        _padInteractionFeature = new PadInteractionFeature(Contexts.sharedInstance);
        _viewFeature = new ViewFeature(Contexts.sharedInstance);
        #endregion
        
        #region INITALIZATION
        _playerInputFeature.Initialize();
        _playerFeature.Initialize();
        _playerMovementFeature.Initialize();
        _padInteractionFeature.Initialize();
        _viewFeature.Initialize();
        #endregion
    }

    private void Update()
    {
        #region EXECUTION
        _playerInputFeature.Execute();
        _playerFeature.Execute();
        _playerMovementFeature.Execute();
        _padInteractionFeature.Execute();
        _viewFeature.Execute();
        #endregion
    }

    private void LateUpdate()
    {
        #region CLEANUP
        _playerInputFeature.Cleanup();
        _playerFeature.Cleanup();
        _playerMovementFeature.Cleanup();
        _padInteractionFeature.Cleanup();
        _viewFeature.Cleanup();
        #endregion
    }
}