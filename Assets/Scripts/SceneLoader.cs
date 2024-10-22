using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Update()
    {
        // Check if Escape is pressed and the "Game" scene is loaded
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetSceneByName("Game").isLoaded)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Public method to start the game from the menu, directly loading the scene
    public void PlayGameFromMenu(int level)
    {
        PlayGame(level);
    }

    // Directly load the game scene without delay
    public void PlayGame(int level)
    {
        switch (level)
        {
            case 0:
                SceneManager.LoadScene("Game");
                break;
        }
    }

    // Load the main menu scene
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Quit the application
    public void QuitGame()
    {
        Application.Quit();
    }
}
