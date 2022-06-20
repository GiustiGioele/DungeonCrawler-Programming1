using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Image HealthBar;

    public float health, maxHealth = 100;


    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        HealthBar.fillAmount = (float)health/maxHealth;
    }
}
