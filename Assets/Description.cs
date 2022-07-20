using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Description : MonoBehaviour
{
    public GameObject nadesc;
    public GameObject sodium;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onViewMore(){
        if(nadesc.activeInHierarchy==false)
        {   nadesc.SetActive(true);

        }

    }
    public void onClose(){
        if(nadesc.activeInHierarchy==true)
        {   nadesc.SetActive(false);
            
        }



    }
}
