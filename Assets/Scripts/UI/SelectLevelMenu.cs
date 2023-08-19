using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelMenu : MonoBehaviour
{
    [SerializeField] Button backButton;
    [SerializeField] Transform grid;
    [SerializeField] LevelButton levelButton;
    [SerializeField] int levelCount = 2;

    void Start()
    {
        foreach (var i in Enumerable.Range(1, levelCount))
        {
            var instance = Instantiate(levelButton, grid);
            instance.SetLevel(i);
        }

        backButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainMenu");
        });
    }
}
