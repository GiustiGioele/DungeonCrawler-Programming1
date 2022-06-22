using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaKeDamagePlayer : MonoBehaviour
{
    public int  EnemyLife=0;
    public GameObject object1;
    public int damage1 = 1;
    public int damage2 = 2;
    [SerializeField] GameObject key;
    static bool isSpawned=false;
    public void TakeDamage()
    {
       EnemyLife=EnemyLife-damage1;
    }
    private void OnTriggerEnter(Collider other)
    {

        //Debug.Log("dentro");
        if (other.gameObject.tag == "PlayerWeapon")
        {
            TakeDamage();
            Debug.Log(EnemyLife);
        }
    }
   
    private void Update()
    {
        
        if(EnemyLife==0)
        {
            Destroy(this.gameObject);
            Destroy(object1);
            if(isSpawned)
            {
                var randint=Random.Range(0,2);
                if(randint==1)
                {
                    GameObject.Instantiate(key, this.gameObject.transform.position, Quaternion.identity);
                    isSpawned=true;
                }
            }
        }
    }

}
