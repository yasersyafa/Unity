using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    private void Start()
    {
        //this.gameObject.transform.position = new Vector3(0f, 0.75f, -8.26f);
    }

    void Update()
    {
        // Input untuk perpindahan jalur (gunakan input sesuai kebutuhan)
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x <= -2)
            {
                transform.Translate(Vector3.zero);
            }
            else
            {
                MoveLane(-1); // Pindah ke kiri
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x >= -0.05)
            {
                transform.Translate(Vector3.zero);
            }
            else
            {
                MoveLane(1); // Pindah ke kanan
            }
        }
    }

    void MoveLane(int direction)
    {
        transform.Translate(Vector3.right * direction);
    }

    private float velocity; // Variabel untuk efek smoothing
}
