using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    [SerializeField] GameObject Object;
    [SerializeField] PlayerController player;
    public bool inRange=false;

    private void OnTriggerEnter(Collider other)
    {
        inRange=true;

    }
    public void Collected()
    {
       if (player.collected)
        {
            Destroy(this.gameObject);
        }
    }
}
