using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    public void SetLevel(int level)
    {
        text.text = level.ToString();
        var button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Level" + level);
        });
        button.interactable = ProgressionManager.IsLevelUnlocked(level);
    }
}
