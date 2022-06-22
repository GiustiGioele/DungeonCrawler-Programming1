using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenù : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
