using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    //public AudioManager audioManager;
    public void EndGame()
    {
        AudioManager.Instance.CloseMusic();
        //audioManager.CloseMusic();
    }
}
