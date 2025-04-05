using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
    }

	private void FixedUpdate() {
        if(x > 0.1f) {
            rb.velocity = new Vector3(3f, 0.0f, 0.0f);
            transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }
        else if(x < -0.1f) {
            rb.velocity = new Vector3(-3f, 0.0f, 0.0f);
            transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
        }
        else {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
	}
}
