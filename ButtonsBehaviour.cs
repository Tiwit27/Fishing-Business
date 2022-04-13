using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsBehaviour : MonoBehaviour
{
    GameObject author;
    GameObject buttons;
    GameObject settings;
    void Start()
    {
        //przypisanie obiektów
        author = GameObject.FindWithTag("author");
        buttons = GameObject.FindWithTag("buttons");
        settings = GameObject.FindWithTag("settings");
        author.SetActive(false);
        buttons.SetActive(true);
        settings.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    public void Settings()
    {
        buttons.SetActive(false);
        author.SetActive(false);
        settings.SetActive(true);
    }
    public void Author()
    {
        buttons.SetActive(false);
        author.SetActive(true);
        settings.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
    void Update()
    {
        //autor
        if (author.activeSelf)
        {
            if (Input.anyKeyDown)
            {
                buttons.SetActive(true);
                author.SetActive(false);
            }
        }
    }
    public void Back()
    {
        //powrót
        author.SetActive(false);
        buttons.SetActive(true);
        settings.SetActive(false);
    }
}
