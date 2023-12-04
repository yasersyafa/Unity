using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform lane1, lane2, lane3;

    // Update is called once per frame
    void Update()
    {
        //Player Movement left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        //Player movement right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
    }

    void MoveRight()
    {
        if(this.gameObject.transform.position.x < RoadBoundary.right)
        {
            if(this.gameObject.transform.position.x == 0)
            {
                transform.position = new Vector3(lane1.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }

            if (this.gameObject.transform.position.x == -1)
            {
                transform.position = new Vector3(lane2.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
        }
    }

    void MoveLeft()
    {
        if(this.gameObject.transform.position.x > RoadBoundary.left)
        {
            if (this.gameObject.transform.position.x == 0)
            {
                transform.position = new Vector3(lane3.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }

            if (this.gameObject.transform.position.x == 1)
            {
                transform.position = new Vector3(lane2.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
            }
        }
    }
}
