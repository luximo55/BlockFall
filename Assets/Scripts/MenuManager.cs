using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }
    public void PlayAgainButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
