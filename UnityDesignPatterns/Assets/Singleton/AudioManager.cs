using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
    }
    public void OpenMusic()
    {
        print("Audio Manager opened the music");
    }
    public void CloseMusic()
    {
        print("Audio Manager closed the music");
    }
}
