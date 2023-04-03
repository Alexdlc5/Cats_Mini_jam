using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource[] audio = GameObject.FindObjectsOfType<AudioSource>();
        if (Game_Manager.mute)
        {
            foreach (AudioSource a in audio)
            {
                a.volume = 0;
            }
        }
        else
        {
            foreach (AudioSource a in audio)
            {
                a.volume = Game_Manager.volume;
            }
        }
    }
}
