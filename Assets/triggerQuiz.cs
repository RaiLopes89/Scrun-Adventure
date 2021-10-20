using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerQuiz : MonoBehaviour
{
    private CanvasGroup Canvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Safe")
        {
            
        }
    }
}
