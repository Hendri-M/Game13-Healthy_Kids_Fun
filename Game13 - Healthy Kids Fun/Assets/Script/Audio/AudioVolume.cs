using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] AudioSource instanceFromAudioManager;

    float volume;
    float maxVolume = 1f;
    float minVolume = 0;

    void Start()
    {
        instanceFromAudioManager = AudioManager.audioInstance.GetComponentInChildren<AudioSource>();
        
        // if (instanceFromAudioManager == AudioManager.audioInstance.BGM)
        // {
        //     AudioManager.audioInstance.switchAudio();
        // }
        AudioManager.audioInstance.switchAudio();

        volume = PlayerPrefs.GetFloat("Volume");
        
        slider.value = volume;
        instanceFromAudioManager.volume = volume;
    }

    public void volumeUp()
    {
        if (volume <= maxVolume)
        {
            volume += 0.1f;
            slider.value = volume;
        }

        // AudioManager.audioInstance.BGM.volume = volume;
        instanceFromAudioManager.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void volumeDown()
    {
        if (volume >= minVolume)
        {
            volume -= 0.1f;
            slider.value = volume;
        }

        instanceFromAudioManager.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);
    }
}
