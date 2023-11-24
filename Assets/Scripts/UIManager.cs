using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;    

    
    private void Start()
    {
        scoreText.text = $"Best Score: {DataManager.Instance.playerName}: {DataManager.Instance.highScore}";
    }
}
