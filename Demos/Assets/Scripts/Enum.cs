using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{

    public GameObject Sphere;
    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject Capsule;

    public enum ShapeName
    {
        Sphere,
        Cube,
        Capsule,
        Cylinder
    }

    public ShapeName currentShape;

    // Start is called before the first frame update
    void Start()
    {
        currentShape = ShapeName.Cube;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentShape)
        {
            case ShapeName.Cube:
                {
                    Cube.SetActive(true);
                    Capsule.SetActive(false);
                    Cylinder.SetActive(false);
                    Sphere.SetActive(false);
                }
                break;

            case ShapeName.Sphere:
                {
                    Cube.SetActive(false);
                    Capsule.SetActive(false);
                    Cylinder.SetActive(false);
                    Sphere.SetActive(true);
                }
                break;

            case ShapeName.Capsule:
                {
                    Cube.SetActive(false);
                    Capsule.SetActive(true);
                    Cylinder.SetActive(false);
                    Sphere.SetActive(false);
                }
                break;

            case ShapeName.Cylinder:
                {
                    Cube.SetActive(false);
                    Capsule.SetActive(false);
                    Cylinder.SetActive(true);
                    Sphere.SetActive(false);
                }
                break;
        }
    }
}
