using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlllerBasic : MonoBehaviour
{

    public float Speed = 10f;

    private CharacterController _controller; //Add character controller component to player

    void Start()
    {
        _controller = GetComponent<CharacterController>(); //reference to the cahracter controller component
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //predefined axes in Unity linked to WASD controllers
        _controller.Move(move * Time.deltaTime * Speed); //moves character in the given direction from our move vector3

        if(move != Vector3.zero)
        {
            transform.forward = move; //character rotates with directional movement
        }
    }
}
