using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainCrystalScript : MonoBehaviour
{
    public bool ActivatedA;
    public bool ActivatedB;
    public bool ActivatedC;
    public bool ActivatedD;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateA()
    {
        Debug.Log("Crystal 1 activated");
        ActivatedA = true;
    }


    public void ActivateB()
    {
        Debug.Log("Crystal 2 activated");
        ActivatedB = true;
    }


    public void ActivateC()
    {
        Debug.Log("Crystal 3 activated");
        ActivatedC = true;
    }

    public void ActivateD(bool ActivateA, bool ActivateB, bool ActivateC)

    {
        if (ActivateA == true && ActivateB == true && ActivateC == true) {
        Debug.Log("Crystal 4 activated");
        ActivatedD = true;
        }
    }

}
