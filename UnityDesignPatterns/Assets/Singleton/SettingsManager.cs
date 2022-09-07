using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    /*first way without singleton
    public ShakeManager shakeManager;
    public AudioManager audioManager;*/

    private void Start()
    {
        /* second way without singleton
        shakeManager = GameObject.FindObjectOfType<ShakeManager>();
        audioManager = GameObject.FindObjectOfType<AudioManager>();*/
        OpenAllSettings();
    }
    public void OpenAllSettings()
    {
        ShakeManager.Instance.OpenShake();
        AudioManager.Instance.OpenMusic();
        /*without singleton
        audioManager.OpenMusic();
        shakeManager.OpenShake();*/
    }
    public void CloseAllSettings()
    {
        ShakeManager.Instance.CloseShake();
        AudioManager.Instance.CloseMusic();
        /*without singleton
        audioManager.CloseMusic();
        shakeManager.CloseShake();*/
    }
}
