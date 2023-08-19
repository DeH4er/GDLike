using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float jump = 18.95f;

    Rigidbody2D rb;
    Animator spriteAnimator;
    ParticleSystem particles;
    bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteAnimator = GetComponentInChildren<Animator>();
        particles = GetComponentInChildren<ParticleSystem>();
    }

    void Update()
    {
        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKey(KeyCode.Space)))
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.gravityScale * jump);
        }
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.collider.CompareTag("Ground"))
        {
            foreach (var contact in hit.contacts)
            {
                var angle = Vector2.Angle(contact.normal, Vector2.up * rb.gravityScale);

                // if hits ground, considers gravity
                if (Mathf.Approximately(angle, 0))
                {
                    isGrounded = true;
                    spriteAnimator.SetBool("isGrounded", isGrounded);
                    particles.Play();
                    return;
                }
            }
        }

    }

    void OnCollisionExit2D(Collision2D hit)
    {
        if (hit.collider.CompareTag("Ground"))
        {
            isGrounded = false;
            particles.Stop();
            spriteAnimator.SetBool("isGrounded", isGrounded);
        }
    }
}
