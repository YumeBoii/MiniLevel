using UnityEngine;

public class Bouncing : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 500f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force);
        }
    }
}
