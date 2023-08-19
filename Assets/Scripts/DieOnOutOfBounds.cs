using UnityEngine;

public class DieOnOutOfBounds : MonoBehaviour
{
    [SerializeField] float maxY = 8.5f;
    [SerializeField] float minY = -4.5f;
    Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (transform.position.y > maxY || transform.position.y < minY)
        {
            player.Die();
        }
    }
}
