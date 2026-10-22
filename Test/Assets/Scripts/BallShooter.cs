using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public Vector3 initialVelocity = new Vector3(8f, 0f, 0f);

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = initialVelocity;
    }
}
