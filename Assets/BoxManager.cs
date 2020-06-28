using Invector;
using Invector.vCharacterController.vActions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoxContainer
{
    public bool IsWorking = true;
    public GameObject Box;
    public int Id;
    public vPlatform platform;
}



public class BoxManager : MonoBehaviour
{
    public List<BoxContainer> allBoxes;
    // Start is called before the first frame update

    public void DisableBox(int Id)
    {
        int counter = 0;
        BoxContainer boxToDissable = allBoxes.Find(ab => ab.Id == Id);
        boxToDissable.IsWorking = false;
        //boxToDissable.Box.GetComponent<vTriggerGenericAction>().enabled = false;
        for (int index = 0; index < allBoxes.Count; index++)
        {
            if (!allBoxes[index].IsWorking)
            {
                counter++;
            }

            if (counter > 1)
            {
                foreach (BoxContainer bc in allBoxes)
                {
                    bc.platform.pause = true;
                }
                    boxToDissable.IsWorking = true;
            }
            else
            {
                boxToDissable.platform.pause = false;
            }
        }
    }
}
