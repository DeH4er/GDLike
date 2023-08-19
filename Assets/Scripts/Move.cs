using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
}
