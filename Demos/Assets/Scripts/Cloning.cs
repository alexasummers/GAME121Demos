using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloning : MonoBehaviour
{
    public GameObject gameObject;

   [SerializeField]
    private int serializedPrivateInt = 3;

    [SerializeField]
    private float serializedPrivateFloat = 6.6f;

    public float publicFloat = 16.52f;

    private int privateInt = 11;

    public static int publicStaticInt = 234;

    void Start ()
    {
        Debug.Log("SerializedPrivateInt = " + serializedPrivateInt + " SerializedPrivateFloat = " + serializedPrivateFloat 
        + " PublicFloat = " + publicFloat + " PrivateInt = " + privateInt + " PubicStaticInt = " + publicStaticInt);
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            serializedPrivateInt = -24;
            serializedPrivateFloat = -190;
            publicFloat = -6790;
            privateInt = -78;
            publicStaticInt = 6;
            GameObject.Instantiate (gameObject);
        }
    }
}
