using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource effectsSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        AudioListener.volume = GetMasterVolume();
        musicSource.volume = GetMusicVolume();
        effectsSource.volume = GetEffectsVolume();
    }

    public void PlayEffect(AudioClip clip)
    {
        effectsSource.PlayOneShot(clip);
    }

    public void SetMasterVolume(float volume)
    {
        PlayerPrefs.SetFloat("MasterVolume", volume);
        AudioListener.volume = volume;
    }

    public void SetMusicVolume(float volume)
    {
        PlayerPrefs.SetFloat("MusicVolume", volume);
        musicSource.volume = volume;
    }

    public void SetEffectsVolume(float volume)
    {
        PlayerPrefs.SetFloat("EffectsVolume", volume);
        effectsSource.volume = volume;
    }

    public float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", .5f);
    }

    public float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", .3f);
    }

    public float GetEffectsVolume()
    {
        return PlayerPrefs.GetFloat("EffectsVolume", .6f);
    }
}
