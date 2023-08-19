using UnityEngine;

public class DieOnSideCollision : MonoBehaviour
{
    Player player;

    void Start()
    {
        player = GetComponent<Player>();
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        DieOnRightSideCollision(hit);
    }

    void OnCollisionStay2D(Collision2D hit)
    {
        DieOnRightSideCollision(hit);
    }

    void DieOnRightSideCollision(Collision2D hit)
    {

        if (hit.collider.CompareTag("Ground"))
        {
            foreach (var contact in hit.contacts)
            {
                var angle = Vector2.Angle(contact.normal, Vector2.left);

                // if hits right side of the wall
                if (Mathf.Approximately(angle, 0))
                {
                    player.Die();
                    return;
                }
            }
        }
    }
}
