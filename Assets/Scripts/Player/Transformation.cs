using UnityEngine;

public class Transformation : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject triangle;

    private bool isCubeActive = true;
    private bool isSphereActive = false;
    private bool isTriangleActive = false;

    void Update()
    {
        CheckKeyAlpha();
        ChangeShape();
    }

    void ToggleObjectsCube() // Toggle Player Cube Object
    {
        isCubeActive = true;
        isSphereActive = false;
        isTriangleActive = false;
    }

    void ToggleObjectsSphere() // Toggle Player Sphere Object
    {
        isCubeActive = false;
        isSphereActive = true;
        isTriangleActive = false;
    }

    void ToggleObjectsTriangle() // Toggle Player Triangle Object
    {
        isCubeActive = false;
        isSphereActive = false;
        isTriangleActive = true;
    }

    void CheckKeyAlpha() // Check Key Input
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ToggleObjectsCube();
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ToggleObjectsSphere();
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ToggleObjectsTriangle();
        }
    }
    void ChangeShape() // Change the shape of the player
    {
        if (isCubeActive)
        {
            cube.SetActive(true);
            sphere.SetActive(false);
            triangle.SetActive(false);
        }

        if (isSphereActive)
        {
            cube.SetActive(false);
            sphere.SetActive(true);
            triangle.SetActive(false);
        }

        if (isTriangleActive)
        {
            cube.SetActive(false);
            sphere.SetActive(false);
            triangle.SetActive(true);
        }
    }
}