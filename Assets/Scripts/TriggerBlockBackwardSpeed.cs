using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlockBackwardSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "SpaceShip")
        {
            other.GetComponent<SpaceShipController>().isBlockedBackward = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "SpaceShip")
        {
            other.GetComponent<SpaceShipController>().isBlockedBackward = false;
        }
    }
}
