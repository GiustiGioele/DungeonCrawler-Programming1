using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource swordAttack;

    public void PlaySwordSound()
    {
        swordAttack.Play();
    }
}
