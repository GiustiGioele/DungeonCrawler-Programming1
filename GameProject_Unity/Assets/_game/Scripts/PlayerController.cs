using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput );
        transform.Translate(movementDirection * speed * Time.deltaTime);
        movementDirection.Normalize();

        if (movementDirection != Vector3.zero)
        {
            //transform.forward = movementDirection;
            animator.SetBool("IsRun", true);
            //Debug.Log("diocane");

        }
    }
}
