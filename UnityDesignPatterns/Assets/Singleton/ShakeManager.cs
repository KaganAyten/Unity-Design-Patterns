using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeManager : MonoBehaviour
{
    public static ShakeManager Instance;
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
    public void OpenShake()
    {
        print("Shake Manager opened the shaking");
    }
    public void CloseShake()
    {
        print("Shake Manager closed the shaking");
    }
}
