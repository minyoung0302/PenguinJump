using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public GameObject help;
    public AudioSource btnSource;
    public AudioClip btnClip;

    void start()
    {
        btnSource = GetComponent<AudioSource>();
        btnClip = Resources.Load<AudioClip>("Button");
    }
    public void StartBtn()
    {
        SceneManager.LoadScene(1);
        ClickSound();
    }
    public void ShowHelp()
    {
        ClickSound();
        help.SetActive(true);
    }
    public void ClickSound()
    {
        btnSource.PlayOneShot(btnClip);
    }
}