using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenù : MonoBehaviour
{
 public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        SceneManager.LoadScene(3);
    }
}
