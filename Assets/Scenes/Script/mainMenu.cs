using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void Back()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Startlevel1()
    {
        SceneManager.LoadScene("level 1");
    }

    public void Startleve2()
    {
        SceneManager.LoadScene("level 2");
    }

    public void Startleve3()
    {
        SceneManager.LoadScene("level 3");
    }

    public void EndGame()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("SettingScene");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
