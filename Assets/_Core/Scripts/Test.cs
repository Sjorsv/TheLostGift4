using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<Animator> anims;

    public void ChangeToWater()
    {        
        for (int i = 0; i < anims.Count; i++)
        {
            print("toWater");
            StartCoroutine(DoAnimation(anims[i], "toWater"));
        }
    }

    public void ChangeToSteam()
    {        
        for (int i = 0; i < anims.Count; i++)
        {
            print("toSteam");
            StartCoroutine(DoAnimation(anims[i], "toSteam"));
        }
    }

    public void ChangeToOriginal()
    {        
        for (int i = 0; i < anims.Count; i++)
        {
            print("toOrigin");
            StartCoroutine(DoAnimation(anims[i], "toOrigin"));
        }
    }

    IEnumerator DoAnimation(Animator anims, string animTrigger)
    {
        print("PlayingAnim");
        anims.SetTrigger(animTrigger);
        yield return new WaitForSeconds(anims.GetCurrentAnimatorStateInfo(0).length + anims.GetCurrentAnimatorStateInfo(0).normalizedTime);
        anims.SetTrigger(animTrigger);
        print("EndAnim");
    }

    //public void ChangeToSteam()
    //{
    //    for (int i = 0; i < anims.Count; i++)
    //    {
    //        anims[i].SetTrigger("TriggerNaam");
    //        if (anims[i].GetCurrentAnimatorStateInfo(0).IsName("Animname(ChangeToSteamColour"))
    //        {

    //        }
    //    }
    //}
}
