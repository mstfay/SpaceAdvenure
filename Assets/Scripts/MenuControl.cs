﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    [SerializeField]
    Sprite[] musicIcons;

    [SerializeField]
    Button musicButton;

    bool musicOn = true;
    // Start is called before the first frame update
    void Start()
    {
        if (Options.HaveISave() == false)
        {
            Options.EasyValueAssignment(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void HighScore()
    {
        SceneManager.LoadScene("Score");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Music()
    {
        if (musicOn)
        {
            musicOn = false;
            musicButton.image.sprite = musicIcons[0];
        }
        else
        {
            musicOn = true;
            musicButton.image.sprite = musicIcons[1];
        }
    }
}
