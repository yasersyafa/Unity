using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangularCollider : MonoBehaviour
{
    public GameObject gameOver;
    public Collider triangularCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "PlayerTriangle")
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
        else
        {
            triangularCollider.enabled = false;
            Debug.Log("skor 1");
            LoseSystem.instance.score++;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
