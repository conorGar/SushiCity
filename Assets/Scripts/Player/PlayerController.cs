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
        if (GameStateManager.Instance.GetCurrentState() == typeof(GameplayState))
        {
            var playerStateController = GetComponent<PlayerStateController>();


            //TODO: InputAction managers and change states based on movement key pressed
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, 0, Input.GetAxis("Vertical") * movementSpeed);



            if(moveDirection != Vector3.zero && playerStateController.GetCurrentState() == PlayerState.IDLE)
            {
                playerStateController.SendTrigger(PlayerTrigger.WALK);

            }else if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && playerStateController.GetCurrentState() == PlayerState.WALKING)
            {
                playerStateController.SendTrigger(PlayerTrigger.IDLE);

            }

            moveDirection.y = moveDirection.y + Physics.gravity.y;
            controller.Move(moveDirection * Time.deltaTime);
        }

    }
}
