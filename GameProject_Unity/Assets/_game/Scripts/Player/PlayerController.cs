using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5;
    //[SerializeField] SoundManager soundManager;
    [SerializeField] AudioSource walksound;
    [SerializeField] AudioSource attacksound;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] Animator animator;
    [SerializeField] Vector3 arrive;
    [SerializeField] Animator animatorAttack;
    void Start()
    {
       
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
            //walksound.Play();

        }
        else if (Input.GetKeyDown(KeyCode.T)) 
        {
            transform.Translate(arrive);
            
            
        }
        else
        {
            animator.SetBool("IsRun", false);
        }


    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("IsAttacking",true);
            //Debug.Log("Attacca");
            attacksound.Play();
        }
        else
        {
            animator.SetBool("IsAttacking",false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("IsAttacking2",true);
            //Debug.Log("Attacca2");
        }
        else
        {
            animator.SetBool("IsAttacking2",false );
        }
    }
}       
