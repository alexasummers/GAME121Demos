using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeltaTime : MonoBehaviour
{
    private float speed = 5f;

    void Update()
    {
        Debug.Log("Time.deltaTime value: " + Time.deltaTime + " || Frames Per Second: " + 1.0f / Time.smoothDeltaTime);

        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
