using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager audioInstance;

    public AudioClip[] clipBGM;
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
        BGM = GetComponentInChildren<AudioSource>();
    }

    private void Start()
    {
        switchAudio();
    }

    public void switchAudio()
    {
        for (int i = 0; i < clipBGM.Length; i++)
        {
            if (i == SceneManager.GetActiveScene().buildIndex)
            {
                BGM.Pause();

                BGM.clip = clipBGM[i];
                BGM.Play();

                break;
            }
        }
    }

}
