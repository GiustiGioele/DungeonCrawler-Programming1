using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] LifeBar life;
    //public GameObject object1;
   public int damage=0;
    public int damPlayer;
    
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("dentro1");

       
        
            life.health -= damage;
            Debug.Log(damage);
        
       
        
        
    }

   
}
