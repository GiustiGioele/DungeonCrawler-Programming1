using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
  
   [SerializeField]  PlayerController player;
   static public bool inRange=false;
    public bool collected = false;

    private void OnTriggerEnter(Collider other)
    {
        inRange=true;

    }
    private void OnTriggerExit(Collider other)
    {
        inRange =false;
    }
    
        
    
    public void Collected()
    {
       if (PlayerController.collected)
        {
            Destroy(this.gameObject);
        }
    }
    private void Update()
    {
        Collected();
    }
}
