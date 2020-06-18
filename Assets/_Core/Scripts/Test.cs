using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<Animator> anims;
    bool check;

    public void ChangeToWater()
    {        
        print("toWater");
        StartCoroutine(Somewhere(anims, "toWater"));
    }

    public void ChangeToSteam()
    {        
        print("toSteam");
        StartCoroutine(Somewhere(anims, "toSteam"));
    }

    public void ChangeToOriginal()
    {        
        print("toOrigin");
        StartCoroutine(Somewhere(anims, "toOrigin"));
    }

    IEnumerator Somewhere(List<Animator> anims, string animTrigger)
    {
        check = false;
        for (int i = 0; i < anims.Count; i++)
        {
            yield return StartCoroutine(WaitSStartCheck(anims[i], animTrigger));
            if (check)
            {
                print("PlayingAnim");
                anims[i].SetTrigger(animTrigger);
            }
        }
    }

    IEnumerator WaitSStartCheck(Animator anims, string animTrigger)
    {
        print(anims.GetCurrentAnimatorStateInfo(0).length + anims.GetCurrentAnimatorStateInfo(0).normalizedTime);
        yield return new WaitForSeconds(anims.GetCurrentAnimatorStateInfo(0).length);
        print("EndAnim");
        check = true;
    }
}
