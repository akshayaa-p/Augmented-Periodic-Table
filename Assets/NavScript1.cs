using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavScript1 : MonoBehaviour
{
    public void Menu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
}
