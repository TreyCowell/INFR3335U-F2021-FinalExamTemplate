using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickMovement : MonoBehaviour
{
    public Joystick joystick;
    public CharacterController Robot2;
    Vector3 movementDirection;
    public float gravity = 15.0f;//Gravity intensity
    public float speed;
    //Vector3 lastPosition = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hori = joystick.Horizontal;
        float vert = joystick.Vertical;
        movementDirection = new Vector3(hori, 0, vert);//vert = 0
        //movementDirection = new Vector3(0, 0, vert);

        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        Robot2.Move(movementDirection * Time.deltaTime);
    }
}