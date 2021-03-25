using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class stores relevant information about a page of UI
/// </summary>
public class Options : MonoBehaviour
{
    AudioSource audioSource;

    public void toggleMute()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.mute = !audioSource.mute;
    }

    public void toggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
