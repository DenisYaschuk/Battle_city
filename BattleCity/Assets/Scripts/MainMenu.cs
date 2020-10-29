using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ChooseTank()
    {
        SceneManager.LoadScene(1);
    }
    public void SinglePlayer()
    {
        SceneManager.LoadScene(2);
    }
    public void MultiPlayer()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
