using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetSceneByName("MainScene").isLoaded)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Public method to start the game from the menu, directly loading the scene
    public void PlayGameFromMenu(int level)
    {
        PlayGame(level);
    }

    public void PlayGame(int level)
    {
        switch (level)
        {
            case 0:
                SceneManager.LoadScene("MainScene");
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
