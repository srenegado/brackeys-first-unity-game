using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Applying forces
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
