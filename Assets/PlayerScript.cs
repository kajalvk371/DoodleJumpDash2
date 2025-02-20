using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour
{
    public float movementSpeed = 10;
    private float movement = 0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        // Flip the sprite based on movement direction
        if (movement > 0)
            transform.localScale = new Vector3(1, 1, 1); // Face right
        else if (movement < 0)
            transform.localScale = new Vector3(-1, 1, 1); // Face left
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity; // Fixed typo (was rb.linearVelocity)
        velocity.x = movement;
        rb.linearVelocity = velocity;
    }
}
