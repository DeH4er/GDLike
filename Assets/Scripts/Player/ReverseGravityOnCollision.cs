using UnityEngine;

public class ReverseGravityOnCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<Player>().ReverseGravity();
        }
    }
}
