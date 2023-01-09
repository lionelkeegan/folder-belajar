using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; set; }
    public Slider Slidervolume;
    public Toggle MuteUnmute;
    public AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveVolume()
    {
        Instance.audioSource.volume = Slidervolume.value;
        PlayerPrefs.SetFloat("AudioVolume", Slidervolume.value);
        LoadVolume();
    }

    public void LoadVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat("AudioVolume");
        Slidervolume.value = volumeValue;
    }

    public void MuteSound()
    {
        if (MuteUnmute.isOn == true)
        {
            audioSource.mute = false;
        }
        else
        {
            audioSource.mute = true;
        }
    }
}
