using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenu : MonoBehaviour
{
    public void Victory()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Scene1");
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Scene0");
    }
}
