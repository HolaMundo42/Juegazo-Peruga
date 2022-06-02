using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class soundToggle : MonoBehaviour
{
    public AudioMixer audioMixer;
    [SerializeField] Text percentage;
    [SerializeField] Slider theSlider;
    [SerializeField] string whichSound = "General Volume";

    void Start()
    {
        theSlider.value = PlayerPrefs.GetFloat("volume "+whichSound, 10f);
        percentage.text = (int)theSlider.value * 5 + "%";
    }

    public void SetVolume(float vol)
    {
        audioMixer.SetFloat(whichSound, vol);
        percentage.text = (int)vol * 5 +"%";
        PlayerPrefs.SetFloat("volume "+whichSound, vol);
    }
}
