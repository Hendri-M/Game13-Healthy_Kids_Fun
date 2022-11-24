using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioInstance;

    public AudioSource BGM;

    private void Awake()
    {
        if (audioInstance != null)
        {
            Destroy(audioInstance);
        }
        else
        {
            audioInstance = this;
            DontDestroyOnLoad(audioInstance);
        }
    }

}
