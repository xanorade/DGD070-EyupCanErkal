using System.Collections;
using System.Collections.Generic;
using Entitas.Unity;
using UnityEngine;

public class TowerDetector : MonoBehaviour
{
    private EntityLink _link;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Material _triggeredMaterial;
    
    private bool _isTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if(_isTriggered) return;
        _isTriggered = true;
        
        HandleEntity();
        HandleMaterial();
        Debug.Log("Detected");
    }

    private void HandleEntity()
    {
        _link = GetComponent<EntityLink>();
        if (_link != null)
        {
            GameEntity towerEntity = _link.entity as GameEntity;
            if (towerEntity != null)
            {
                towerEntity.isTowerDestroyed = true;
                _link.Unlink();
            }
        }
    }

    private void HandleMaterial()
    {
        _meshRenderer.material = _triggeredMaterial;
    }
}
