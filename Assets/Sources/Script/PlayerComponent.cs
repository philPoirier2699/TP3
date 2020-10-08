using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    private ScoreManagerComponent scoreManager; 
    private void Awake()
    {
        scoreManager = FindObjectOfType<ScoreManagerComponent>();

    }

    
}
