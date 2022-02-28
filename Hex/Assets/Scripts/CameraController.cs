using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //CharacterController characterController;

    public float speed = 0;

    //private Vector3 moveDirection = Vector3.zero;


    void Start()
    {
        //characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += speed;
            this.transform.position = position;
        }
        //moveDirection = new Vector3(vert, 0f, horiz);
        //moveDirection *= speed;

        //characterController.Move(moveDirection * Time.deltaTime);
    }

}
