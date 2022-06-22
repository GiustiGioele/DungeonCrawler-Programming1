using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] LifeBar life;
    //public GameObject object1;
    [SerializeField] Teleport damage;
    [SerializeField] Teleport damage2;
    public int damPlayer;
    
    private void OnTriggerEnter(Collider other)
    {



        if (other.CompareTag("agent"))
        {
            Debug.Log("dentro1");
            life.health -= damage.damage;
            Debug.Log(damage.damage);
        }
        else
        {
            life.health -= damage2.damage1;
            Debug.Log(damage.damage1);
        }




    }

   
}
