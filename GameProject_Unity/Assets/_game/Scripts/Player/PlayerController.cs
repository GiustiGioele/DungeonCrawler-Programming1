using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20;
    //[SerializeField] SoundManager soundManager;
    [SerializeField] AudioSource walksound;
    [SerializeField] AudioSource attacksound;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] Animator animator;
    // [SerializeField] Vector3 arrive;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject coll;
    [SerializeField] LifeBar PlayerLife;
    [SerializeField] EnemyDamage enemyDamage;
    [SerializeField] Animator animatorAttack;
    [SerializeField] KeyCollect collect;
    static public bool collected=false;
    public GameObject gameObject;
    void Start()
    {
        coll.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CollectKey();
        EnemyDamage();
        Move();
        Attack();
        Die();
    }

    public void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        movementDirection.Normalize();


        if (movementDirection != Vector3.zero)
        {
            transform.forward = movementDirection;
            animator.SetBool("IsRun", true);

            walksound.Play();

        }

        else
        {
            animator.SetBool("IsRun", false);
        }


    }

    public void EnemyDamage()
    {
        PlayerLife.health -= enemyDamage.damPlayer;
    }
    public void Die()
    {

        if (PlayerLife.health == 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void ActiveCollider()
    {
        coll.SetActive(true);
    }
    public void DeactiveCollider()
    {
        coll.SetActive(false);
    }
    public void CollectKey()
    {
        Debug.Log(KeyCollect.inRange);
        if(Input.GetKeyDown(KeyCode.Mouse1)&KeyCollect.inRange)
        {
            collected=true;
            Debug.Log(collected);
        }
    }
    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("IsAttacking", true);
            //Debug.Log("Attacca");
            //attacksound.Play();
        }
        else
        {
            animator.SetBool("IsAttacking", false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("IsAttacking2", true);
            //Debug.Log("Attacca2");
        }
        else
        {
            animator.SetBool("IsAttacking2", false);
        }
    }
}
