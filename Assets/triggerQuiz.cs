using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerQuiz : MonoBehaviour
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
        if(other.gameObject.name == "SpaceShip")
        {
            Debug.Log("funciona");
            //agora é adicionar o canva
        }
    }
}
