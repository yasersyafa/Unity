using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class LoseSystem : MonoBehaviour
{
    public static LoseSystem instance;
    public int score = 0;

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Awake()
    {
        instance = this;
    }

    void isTriggerEnter()
    {

    }
    void MainMenu()
    {
        SceneManager.LoadScene(2);
        score = 0;
    }
    void Retry()
    {
        SceneManager.LoadScene(1);
        score = 0;
    }
}
