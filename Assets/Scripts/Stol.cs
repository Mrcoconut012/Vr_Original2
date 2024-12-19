using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stol : MonoBehaviour
{
    private int abc = Gub.stol;
    public GameObject stol1;
    
    
    // Update is called once per frame
    void Update()
    {
        if( Gub.stol >=1){
            stol1.SetActive(false);
        }
    }
}
