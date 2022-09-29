using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    Button startButton;
    Button quitButton;

    public InputField playerNameField;
    public string playerName = "Guest";
    public Text bestScoreText;
    
    void Awake() 
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }   
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerCurrentName()
    {
        playerName = playerNameField.text;
    }
    
    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
    
