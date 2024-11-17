using System;
using System.Timers;
using UnityEngine;
using UnityEngine.WSA;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
    [SerializeField] private Toaster _toaster;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _parent;
    private void Awake()
    {
        _toaster = FindObjectOfType<Toaster>();
        _toaster.TimerIsUp += CreateWaffle;
        
    }

    

    private void CreateWaffle()
    {
            Instantiate(_prefab, _parent);
    }
    
}