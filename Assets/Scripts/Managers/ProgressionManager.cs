using UnityEngine;

public class ProgressionManager : MonoBehaviour
{

    public static void CompleteLevel(int level)
    {
        PlayerPrefs.SetInt("lastCompleteLevel", level);
    }

    public static bool IsLevelUnlocked(int level)
    {
        return PlayerPrefs.GetInt("lastCompleteLevel") + 1 >= level;
    }
}