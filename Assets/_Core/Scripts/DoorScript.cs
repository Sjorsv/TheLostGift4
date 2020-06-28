using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField]
    GameObject door;
    public bool dooropened = false;
    private float doorspeed_climb = 1;
    public float RisingSpeed = 1;


    // Start is called before the first frame update
    public void OpenDoor()
    {
        dooropened = true;
    }

    public void CloseDoor()
    {
        dooropened = false;
        // round 1 completeeeeeeeeeeeeee
        // when dead
    }

    private void Update()
    {
        if (dooropened == true)
            if (doorspeed_climb < -65.386)
            {
        {
            //doorspeed_climb += RisingSpeed * Time.deltaTime;
            // 1 + 1 * tijd
            // 1 + 1 * 10s
            // 1 + 1 
            doorspeed_climb += RisingSpeed * Time.deltaTime;
            door.transform.position = new Vector3(door.transform.position.x, doorspeed_climb, door.transform.position.z);
        }
            }
    }



}
