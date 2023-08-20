using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] Button resumeButton;
    [SerializeField] Button quitButton;
    [SerializeField] PlayerInput playerInput;

    void Start()
    {
        resumeButton.onClick.AddListener(Resume);
        quitButton.onClick.AddListener(Quit);
        playerInput.Pause.started += OnPauseInput;
        Resume();
    }

    void OnDestroy()
    {
        playerInput.Pause.started -= OnPauseInput;
    }

    public static bool IsPaused()
    {
        return Mathf.Approximately(Time.timeScale, 0);
    }


    public void Resume()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        playerInput.Jump.Enable();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        playerInput.Jump.Disable();
    }

    public void Toggle()
    {
        if (IsPaused())
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void OnPauseInput(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        Toggle();
    }
}