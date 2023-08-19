using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    public delegate void DeathAction(Player player);
    public static event DeathAction OnDeath;

    public delegate void FinishAction(Player player);
    public static event FinishAction OnFinish;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ReverseGravity()
    {
        rb.gravityScale *= -1;
    }

    public void Die()
    {
        OnDeath(this);
    }

    public void Finish()
    {
        OnFinish(this);
    }
}
