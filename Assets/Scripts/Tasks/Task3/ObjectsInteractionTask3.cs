using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    [SerializeField] private Lamp _lamp;

    private void Awake()
    {
        _lamp = FindObjectOfType<Lamp>();
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _lamp.Interact();
        }

    }
    
    
}




