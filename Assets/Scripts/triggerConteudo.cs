using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggerConteudo : MonoBehaviour
{
    public string quizScene;
    public GameObject content;

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
            content.SetActive(true);

        }
    }
}
