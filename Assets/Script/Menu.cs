using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject help;

    public void Menu_button()
    {
        Time.timeScale = 1; //게임 일시정지
        menuPanel.SetActive(true);
    }

    public void Restart1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Restart2()
    {
        SceneManager.LoadScene(2);
    }
    public void Restart3()
    {
        SceneManager.LoadScene(3);
    }
    public void Restart4()
    {
        SceneManager.LoadScene(4);
    }
    public void Restart5()
    {
        SceneManager.LoadScene(5);
    }

    public void GameExit()
    {
        Application.Quit();
    }
    
    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowHelp()
    {
        help.SetActive(true);
    }
}