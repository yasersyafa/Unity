using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SphereCollider : MonoBehaviour
{
    public GameObject gameOver;
    public Collider sphereCollider;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "PlayerSphere")
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
        else
        {
            sphereCollider.enabled = false;
            Debug.Log("skor 1");
            LoseSystem.instance.score++;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
