
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
     public int lenght = 0;
    [SerializeField] GameObject spawnPoints;
    [SerializeField] GameObject enemy;
    [SerializeField] float timer = 0;
    [SerializeField] float spawnDelay = 1f;
    public void SpawnEnemy()
    {
        int check = 0;
        Debug.Log(check);
        int randInt = RandomLenght();

        if (check < randInt)
        {
            timer += Time.deltaTime;
            if (timer > spawnDelay)
            {




                GameObject.Instantiate(enemy, spawnPoints.transform.position, Quaternion.identity);
                timer = 0;
                check++;
            }
        }
    }
    public int RandomLenght()
    {
         var randInt = Random.Range(0, lenght);
       return randInt;

    }
    private void Update()
    {
        SpawnEnemy();
    }
}

