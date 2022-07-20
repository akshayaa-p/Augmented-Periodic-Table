using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavScript2 : MonoBehaviour
{
    public void Game(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
}
