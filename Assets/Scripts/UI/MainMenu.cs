using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button optionsButton;
    [SerializeField] Button quitButton;
    void Start()
    {
        startButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("SelectLevelMenu");
        });

        optionsButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("OptionsMenu");
        });

        quitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
    }
}
