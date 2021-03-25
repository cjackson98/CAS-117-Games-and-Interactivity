using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeChange : MonoBehaviour
{
    public AudioSource audioSrc;
    // private float musicVolume = 1f;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     audioSrc = GetComponent<AudioSource>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     audioSrc.volume = musicVolume;
    // }

    public void setVolume(float vol)
    {
        // musicVolume = vol;
        audioSrc.volume = vol;
        Debug.Log("Set volume to" + vol.ToString() );
    }

    public void toggleMute()
    {
        audioSrc.mute = !audioSrc.mute;
        Debug.Log("Toggled mute.");
    }
}
