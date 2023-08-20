using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    ParticleSystem particleSystem;
    [SerializeField] AudioClip deathSound;
    [SerializeField] AudioClip finishSound;
    [SerializeField] Transform particlesNormalGravity;
    [SerializeField] Transform particlesReversedGravity;

    public delegate void DeathAction(Player player);
    public static event DeathAction OnDeath;

    public delegate void FinishAction(Player player);
    public static event FinishAction OnFinish;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        particleSystem = GetComponentInChildren<ParticleSystem>();
    }

    public void ReverseGravity()
    {
        rb.gravityScale *= -1;

        if (Mathf.Approximately(rb.gravityScale, 1))
        {
            particleSystem.transform.position = particlesNormalGravity.position;
        }
        else
        {
            particleSystem.transform.position = particlesReversedGravity.position;
        }
    }

    public void Die()
    {
        SoundManager.Instance.PlayEffect(deathSound);
        OnDeath(this);
    }

    public void Finish()
    {
        SoundManager.Instance.PlayEffect(finishSound);
        OnFinish(this);
    }
}
