﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string playGameScene;

    public void PlayGame()
    {
        SceneManager.LoadScene(playGameScene);
    }
}
