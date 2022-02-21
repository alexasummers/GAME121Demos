using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    public float Speed = 10f;
    public float Gravity = -9.81f;

    private CharacterController _controller; //Add character controller component to player
    private Vector3 _velocity;

    void Start()
    {
        _controller = GetComponent<CharacterController>(); //reference to the cahracter controller component
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //predefined axes in Unity linked to WASD controllers
        _controller.Move(move * Time.deltaTime * Speed); //moves character in the given direction from our move vector3

        _velocity.y += Gravity * Time.deltaTime; //setting velocity in the y direction to the acceleration of gravity in relation to our fps (Time.deltaTime)
        _controller.Move(_velocity * Time.deltaTime); //Movement based on velocity

        if (move != Vector3.zero)
        {
            transform.forward = move; //character rotates with directional movement
        }
    }
}
