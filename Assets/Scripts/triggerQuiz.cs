using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggerQuiz : MonoBehaviour
{
    public string quizScene;
    public GameObject QuestionPanel;

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
            //agora � adicionar o canva
            //SceneManager.LoadScene(quizScene);
            QuestionPanel.SetActive(true);
            
        }
    }
}
