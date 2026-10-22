using UnityEngine;

public class Movement : MonoBehaviour
{
   
   public float speed = 5f;
   private Rigidbody rb;

   void Start()
   {
    rb = GetComponent<Rigidbody>();
   }

   void Update()
   {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 direction = new Vector3(horizontal, 0f, vertical);

    rb.linearVelocity = new Vector3(
        direction.x * speed,
        rb.linearVelocity.y,
        direction.z * speed
    );
   }
}
