using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    private int i;
    [SerializeField] private Shelf[] _shelf;
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены

    private void Awake()
    {
        _shelf = FindObjectsOfType<Shelf>();
        
    }

    private void Update()
    {
        
        if (_shelf[0].ItemsCount > 3 )
        {
            _shelf[0].ItemSpawned.Invoke();
        }
        if (_shelf[1].ItemsCount > 3 )
        {
            _shelf[1].ItemSpawned.Invoke();
        }
        
    }
}