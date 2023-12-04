using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRoad : MonoBehaviour
{
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedUp();
    }

    void SpeedUp()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime * -1);
        if (LoseSystem.instance.score == 5)
        {
            speed = 5;
        }
        if (LoseSystem.instance.score == 15)
        {

            speed = 7;
        }

        if (LoseSystem.instance.score == 25)
        {
            speed = 10;
        }
    }
}
