using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionCarbon : MonoBehaviour
{
    public GameObject cdesc;
    public GameObject carbon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onViewMore(){
        if(cdesc.activeInHierarchy==false)
        {   cdesc.SetActive(true);

        }

    }
    public void onClose(){
        if(cdesc.activeInHierarchy==true)
        {   cdesc.SetActive(false);
            
        }



    }
}
