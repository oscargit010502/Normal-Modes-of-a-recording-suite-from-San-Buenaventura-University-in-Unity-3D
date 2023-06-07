using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Comenzar : MonoBehaviour
{
    public void ComenzarJuego(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
