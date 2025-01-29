using Entitas;
using Entitas.Unity;
using UnityEngine;

public class TowerDetector : MonoBehaviour
{
    private EntityLink _link;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Material _triggeredMaterial;
    
    private bool _isTriggered;
    
    private static int _currentTriggerOrder = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (_isTriggered) return;

        _link = GetComponent<EntityLink>();
        GameEntity towerEntity = _link.entity as GameEntity;

        if (towerEntity.triggerOrder.Value != _currentTriggerOrder) return;

        _isTriggered = true;
        
        HandleEntity();
        HandleMaterial();
        Debug.Log($"Detected: {towerEntity.triggerOrder.Value}");

        _currentTriggerOrder++;
    }

    private void HandleEntity()
    {
        _link = GetComponent<EntityLink>();
        GameEntity towerEntity = _link.entity as GameEntity;
        towerEntity.isTowerDestroyed = true;
    }

    private void HandleMaterial()
    {
        _meshRenderer.material = _triggeredMaterial;
    }
}