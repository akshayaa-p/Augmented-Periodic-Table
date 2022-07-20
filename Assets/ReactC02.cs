using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactC02 : MonoBehaviour
{
    public GameObject co2;
    public GameObject carbon;
    public GameObject oxygen1;
    public GameObject oxygen2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onButtonClick(){
        if(co2.activeInHierarchy==false)
        {   co2.SetActive(true);
            oxygen1.SetActive(false);
            carbon.SetActive(false);
            oxygen2.SetActive(false);

        }
        else
        {
            co2.SetActive(false);
            oxygen1.SetActive(true);
            carbon.SetActive(true);
            oxygen2.SetActive(true);
        }



    }
    public void onReset(){
        if(co2.activeInHierarchy==true)
        {   co2.SetActive(false);
            oxygen1.SetActive(true);
            carbon.SetActive(true);
            oxygen2.SetActive(true);
            
        }



    }
}
