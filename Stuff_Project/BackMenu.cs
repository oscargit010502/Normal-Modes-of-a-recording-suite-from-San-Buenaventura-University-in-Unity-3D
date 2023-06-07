using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour
{
    public void RegresarMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
