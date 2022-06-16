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
    [SerializeField] Animator animatorAttack;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput  );
        transform.Translate(movementDirection * speed * Time.deltaTime,Space.World);
        movementDirection.Normalize();

        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
            animator.SetBool("IsRun", true);
            //Debug.Log("diocane");

        }
        else
        {
            animator.SetBool("IsRun", false);
        }


    }

    public void Attack()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animator.SetBool("IsAttacking",true);
        }
        else
        {
            animator.SetBool("IsAttacking",false);
        }
    }
}
