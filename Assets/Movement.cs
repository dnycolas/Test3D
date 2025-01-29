using UnityEngine;

public class Movement : MonoBehaviour
{

    private float dir = 0;
    private float speed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
        {

            if (rb.linearVelocity.magnitude < 250)
            {

                rb.AddForce(Vector3.fwd * speed, ForceMode.Impulse);

            }

        }
        if (Input.GetKey(KeyCode.D))
        {

            if (rb.linearVelocity.magnitude < 250)
            {

                rb.AddForce(Vector3.right * 0.01f, ForceMode.Impulse);

            }

        }
        if (Input.GetKey(KeyCode.A))
        {

            if (rb.linearVelocity.magnitude < 250)
            {

                rb.AddForce(Vector3.left * 0.01f, ForceMode.Impulse);

            }

        }

    }
}
