using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] Explode explode;

    void Start()
    {
        Player.OnDeath += OnPlayerDeath;
        Player.OnFinish += OnPlayerFinish;
    }

    void OnPlayerDeath(Player player)
    {
        Explode.OnAnimationEnd += OnDeathAnimationEnd;

        var position = player.transform.position + Vector3.zero;
        Instantiate(explode, position, Quaternion.identity);
        Destroy(player.gameObject);
    }

    void OnPlayerFinish(Player player)
    {
        Explode.OnAnimationEnd += OnFinishAnimationEnd;
        var position = player.transform.position + Vector3.zero;
        Instantiate(explode, position, Quaternion.identity);
        Destroy(player.gameObject);
    }

    void OnDeathAnimationEnd()
    {
        Explode.OnAnimationEnd -= OnDeathAnimationEnd;
        SceneManager.LoadScene("Level1");
    }

    void OnFinishAnimationEnd()
    {
        Explode.OnAnimationEnd -= OnFinishAnimationEnd;
    }

    void OnDestroy()
    {
        Player.OnDeath -= OnPlayerDeath;
        Player.OnFinish -= OnPlayerFinish;
    }
}
