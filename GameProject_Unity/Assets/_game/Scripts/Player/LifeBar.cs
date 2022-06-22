using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeBar : MonoBehaviour
{
    public Image HealthBar;

    public float health, maxHealth = 100;
    private bool sceneGameover = false;

    private void Start()
    {
        health = maxHealth;
        sceneGameover = false;
    }

    private void Update()
    {
        HealthBar.fillAmount = (float)health/maxHealth;
        GameOver();
    }

    public void GameOver()
    {
        if (health == 0)
        {
            sceneGameover = true;
            SceneManager.LoadScene(2);
        }
    }
}
