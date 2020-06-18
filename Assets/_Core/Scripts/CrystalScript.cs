using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalScript : MonoBehaviour
{
   
    public Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeColor()
    {
        Debug.Log("Crystal moet blauw worden");
        Anim.SetTrigger("turnBlue");
       
    }

}
