using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public CharacterController controller;
    

    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        var playerStateController = GetComponent<PlayerStateController>();

        moveDirection = new Vector3(Input.GetAxis("Horizontal")*movementSpeed,0,Input.GetAxis("Vertical")*movementSpeed);


        moveDirection.y = moveDirection.y + Physics.gravity.y;
        controller.Move(moveDirection * Time.deltaTime);

    }
}
