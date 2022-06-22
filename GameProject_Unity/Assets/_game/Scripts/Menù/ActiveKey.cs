using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveKey : MonoBehaviour
{
    [SerializeField] PlayerController player;
    public Image spriteKey;
    public Sprite sprite;


    public void SetImage()
    {
        if (PlayerController.collected)
        {
            Debug.Log(PlayerController.collected);
            spriteKey.sprite = sprite;
        }
    }
    private void Update()
    {
        SetImage();
    }
}
