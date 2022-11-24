using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioInstance;

    public AudioClip[] ClipBGM;
    public AudioMixerGroup mixer;
    public static AudioSource BGM;

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

    private void Start()
    {
        BGM = GetComponentInChildren<AudioSource>();
        switchAudio();
    }

    public void switchAudio()
    {
        for (int i = 0; i < ClipBGM.Length; i++)
        {
            if (i == SceneManager.GetActiveScene().buildIndex)
            {
                BGM.Pause();

                BGM.clip = ClipBGM[i];
                BGM.Play();

                break;
            }
            
        }
    }

}
