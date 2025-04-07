using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D col;
    private CircleCollider2D col2;

    [SerializeField] private bool isPlayerOne = true;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (GetComponent<BoxCollider2D>() != null)
        {
            col = GetComponent<BoxCollider2D>();
        }
        
        if (GetComponent<CircleCollider2D>() != null)
        {
            col2 = GetComponent<CircleCollider2D>();
        }
    }


    void Update()
    {
        if (isPlayerOne)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Strafe();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded(col))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    private void Strafe()
    {
        rb.linearVelocityX = 0;

        if (isPlayerOne)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocityY);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocityY);
            }
        }
        else if (!isPlayerOne)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.linearVelocity = new Vector2(-moveSpeed, rb.linearVelocityY);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocityY);
            }
        }
    }

    private bool IsGrounded(Collider2D coll)
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayer);
    }
}
