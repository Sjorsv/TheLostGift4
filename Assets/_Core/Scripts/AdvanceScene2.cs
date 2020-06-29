
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdvanceScene2 : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter(Collider coll)
    {
        {
           
                SceneManager.LoadScene(2);

        }
    }
}