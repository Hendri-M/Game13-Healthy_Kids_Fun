using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolume : MonoBehaviour
{
    [SerializeField] Slider slider;

    float volume;
    float maxVolume = 1f;
    float minVolume = 0;

    // Start is called before the first frame update
    void Start()
    {
        volume = PlayerPrefs.GetFloat("Volume");
        
        slider.value = volume;
        AudioManager.audioInstance.BGM.volume = volume;
    }

    public void volumeUp()
    {
        if (volume <= maxVolume)
        {
            volume += 0.1f;
            slider.value = volume;
        }

        AudioManager.audioInstance.BGM.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void volumeDown()
    {
        if (volume >= minVolume)
        {
            volume -= 0.1f;
            slider.value = volume;
        }

        AudioManager.audioInstance.BGM.volume = volume;

        PlayerPrefs.SetFloat("Volume", volume);
    }
}
