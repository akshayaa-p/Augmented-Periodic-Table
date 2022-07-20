using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour
{
    public GameObject nah;
    public GameObject sodium;
    public GameObject hydrogen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onButtonClick(){
        if(nah.activeInHierarchy==false)
        {   nah.SetActive(true);
            sodium.SetActive(false);
            hydrogen.SetActive(false);
        }
        else
        {
            nah.SetActive(false);
            sodium.SetActive(true);
            hydrogen.SetActive(true);

        }



    }
    public void onReset(){
        if(nah.activeInHierarchy==true)
        {   nah.SetActive(false);
            sodium.SetActive(true);
            hydrogen.SetActive(true);
        }



    }
}
