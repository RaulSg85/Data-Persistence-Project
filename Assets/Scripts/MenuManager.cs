using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public InputField playerName;
    public Text bestScore;

    private void Start()
    {        
        bestScore.text = $"Best Score: {DataManager.Instance.playerName}: {DataManager.Instance.highScore}";                
    }
    public void StartButton()
    {        
        DataManager.Instance.playerName = playerName.text;
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    
}
