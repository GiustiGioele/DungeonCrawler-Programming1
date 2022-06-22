using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConditions : MonoBehaviour
{
    private bool gameWin = false;
    [SerializeField] GameObject gameObject;

    private void OnTriggerEnter (Collider other)
    {
      if (other.gameObject.CompareTag("win"))
        {
            gameWin = true;
            SceneManager.LoadScene(4);
            Debug.Log("DIoMerda");
        }
      
    }
}
