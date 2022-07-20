using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavScript : MonoBehaviour
{
    public void Scan(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
