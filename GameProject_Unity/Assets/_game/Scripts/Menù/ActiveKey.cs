using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveKey : MonoBehaviour
{
    [SerializeField] PlayerController player;
    public Image spriteKey;
    public Sprite sprite;

    //public KeyCollect collect;
  public void SetImage()
    {
        if (player.collected)
        {
            spriteKey.sprite = sprite;
        }
    }
}
