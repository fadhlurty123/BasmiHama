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
        SceneManager.LoadScene("GameScene");
    }

    public void SettingGame()
    {
        SceneManager.LoadScene("SettingScene");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        SceneManager.LoadScene("Quit");
    }
}
