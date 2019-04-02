 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "player")
        {
            GameControl.instance.alarmOn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            Invoke("Stop", 4);
        }
    }
    void Stop()
    {
        GameControl.instance.alarmOn = false;
    }
}
