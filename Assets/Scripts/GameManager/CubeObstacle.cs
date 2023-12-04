using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeCollider : MonoBehaviour
{
    public GameObject gameOver;
    public Collider cubeCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "PlayerCube") 
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true); 
        }
        else
        {
            cubeCollider.enabled = false;
            Debug.Log("skor 1");
            LoseSystem.instance.score++;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
