using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BoolVariable gamePaused;
    public BoolVariable hasPlayerDied;
    public BoolVariable hasPlayerWon;
    public StringVariable uiState;
    public IntVariable flareLevel;
    public IntVariable pickupCount;
    public FloatVariable playerHealth;
    public FloatVariable gameTime;
    public BoolVariable isHoldingItem;
    
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        
        string sceneName = currentScene.name;
 
        if (sceneName == "Menu") 
        {
            ResetState();
            uiState.Value = uiState.InitialValue;
        }
        else if (sceneName == "Game")
        {
            ResetState();
            uiState.Value = "PlayerUI";
        }

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused.Value)
            {
                gamePaused.Value = true;
                PauseGame();    
            }
            else
            {
                gamePaused.Value = false;
                ResumeGame();
            }
        }
    }
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        Debug.Log("PAUSE THE GAME");
        uiState.Value = "Pause";
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Debug.Log("UNPAUSE THE GAME");
        uiState.Value = "PlayerUI";
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        uiState.Value = "Ending";
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetState()
    {
        hasPlayerDied.Value = hasPlayerDied.InitialValue;
        hasPlayerWon.Value = hasPlayerWon.InitialValue;
        flareLevel.Value = flareLevel.InitialValue;
        pickupCount.Value = pickupCount.InitialValue;
        playerHealth.Value = playerHealth.InitialValue;
        gameTime.Value = gameTime.InitialValue;
        isHoldingItem.Value = isHoldingItem.InitialValue;
    }
}
