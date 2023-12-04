using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBoundary : MonoBehaviour
{
    public static float left = -1f;
    public static float right = 1f;
    public float internalLeft;
    public float internalRight;
    // Update is called once per frame
    void Update()
    {
        internalLeft = left;
        internalRight = right;
    }
}
