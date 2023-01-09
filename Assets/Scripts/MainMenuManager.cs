using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Toggle MuteUnmute;

    private void Awake()
    {
        if (AudioManager.Instance.audioSource.mute == true)
        {
            MuteUnmute.isOn = false;
        }
        else
        {
            MuteUnmute.isOn = true;
        }
    }
    public void AudioVolume()
    {
        AudioManager.Instance.audioSource.volume = volumeSlider.value;
    }

    public void SetMute()
    {
        if (MuteUnmute.isOn == true)
        {
            AudioManager.Instance.audioSource.mute = false;
        }
        else
        {
            AudioManager.Instance.audioSource.mute = true;
        }
    }

    public void SceneLoad(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
