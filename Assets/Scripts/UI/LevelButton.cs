using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    int level;

    public void SetLevel(int level)
    {
        this.level = level;
        text.text = level.ToString();
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        button.interactable = ProgressionManager.IsLevelUnlocked(level);
    }

    void OnClick()
    {
        SceneManager.LoadScene("Level" + level);
    }
}
