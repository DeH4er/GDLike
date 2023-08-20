using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider effectsSlider;

    void Start()
    {
        masterSlider.value = SoundManager.Instance.GetMasterVolume();
        musicSlider.value = SoundManager.Instance.GetMusicVolume();
        effectsSlider.value = SoundManager.Instance.GetEffectsVolume();

        backButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenu");
        });

        masterSlider.onValueChanged.AddListener(delegate
        {
            SoundManager.Instance.SetMasterVolume(masterSlider.value);
        });

        musicSlider.onValueChanged.AddListener(delegate
        {
            SoundManager.Instance.SetMusicVolume(musicSlider.value);
        });

        effectsSlider.onValueChanged.AddListener(delegate
        {
            SoundManager.Instance.SetEffectsVolume(effectsSlider.value);
        });
    }
}
