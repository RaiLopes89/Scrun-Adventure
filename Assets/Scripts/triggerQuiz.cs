using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggerQuiz : MonoBehaviour
{
    public GameObject QuestionPanel;
    private GameObject player;

    public string triggerPlanetText;

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
        player = GameObject.Find("Player");
        SpaceShipController spaceship = player.transform.GetChild(0).gameObject.GetComponent<SpaceShipController>();
        Debug.Log("Teste1: " + spaceship.currentPlanet);
        Debug.Log("Teste2: " + triggerPlanetText);
        if(other.gameObject.name == "SpaceShip" &  spaceship.currentPlanet == triggerPlanetText)
        {
            Debug.Log("QUIZ - funciona");
            //agora � adicionar o canva
            //SceneManager.LoadScene(quizScene);
            QuestionPanel.SetActive(true);
        }
    }
}
