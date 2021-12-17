using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using DefaultNamespace.ScriptableEvents;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScriptableEventInt onGametimeUpdated; 
    
    private float gameTime;

    private void Update()
    {
        UpdateGameTime();
    }

    private void UpdateGameTime()
    {
        gameTime += Time.deltaTime; 
        onGametimeUpdated.Raise((int)gameTime);
    }
}
