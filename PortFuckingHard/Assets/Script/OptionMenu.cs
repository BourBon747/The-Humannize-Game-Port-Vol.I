using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{

    public AudioMixer audioMixer;
    
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MainVolumePara", volume);
    }

    public void SetMusicVolume(float musicVolume)
    {
        audioMixer.SetFloat("MusicVolumePara", musicVolume);
    }

    public void SetEffectVolume(float effectVolume)
    {
        audioMixer.SetFloat("EffectVolumePara", effectVolume);
    }
}
