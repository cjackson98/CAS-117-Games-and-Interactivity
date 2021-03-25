﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// This class is meant to be used on buttons as a quick easy way to load levels (scenes)
/// </summary>
public class LevelLoadButton : MonoBehaviour
{
    /// <summary>
    /// Description:
    /// Loads a level according to the name provided
    /// Input:
    /// string levelToLoadName
    /// Return:
    /// void (no return)
    /// </summary>
    /// <param name="levelToLoadName">The name of the level to load</param>
    public void LoadLevelByName(string levelToLoadName)
    {
        SceneManager.LoadScene(levelToLoadName);
    }

    /// <summary>
    /// Description:
    /// Reloads the current level
    /// Input:
    /// None
    /// Return:
    /// void (no return)
    /// </summary>
    public void reloadLevel()
    {
        LevelManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
