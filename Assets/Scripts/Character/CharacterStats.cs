using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public UI_HealthBar uiHealth = null;

    private Canvas _canvas = null;

    private Transform mainCamera;


    private void Awake()
    {
        _canvas = GetComponent<Canvas>();
        _canvas.worldCamera = Camera.main;
        mainCamera = Camera.main.transform;
    }

    private void Update()
    {
        uiHealth.transform.LookAt(mainCamera);   
    }
}
