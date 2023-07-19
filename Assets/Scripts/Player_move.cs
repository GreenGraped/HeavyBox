using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    Vector2 movementInput;
    [SerializeField] Vector2 temp_Input = Vector2.zero;
    Transform target;
    [SerializeField] bool input_exist;
    [SerializeField] float movement_speed;
    void Start()
    {
        input_exist = false;
        target = transform.Find("to_move");
    }

    // Update is called once per frame
    void Update()
    {
        movementInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //if (Input.anyKey && !input_exist)
        //{
        //    if (movementInput.x != 0 && movementInput.y != 0)
        //    {
        //        movementInput.x = 0;
        //    }
        //    target.position = Functions.f.V3toV2(transform.position) + (movementInput * movement_speed);
        //    input_exist = true;
        //}
        //else if (Input.anyKey == false && input_exist)
        //{
        //    target.position = transform.position;
        //    input_exist = false;
        //}

        //if (input_exist)
        //{
        //    transform.position = target.position;
        //    target.position = transform.position;
        //    // input_exist = false;
        //}
        if (Input.anyKey && movementInput != temp_Input)
        {
            if (movementInput.x != 0 && movementInput.y != 0)
            {
                movementInput.x = 0;
            }
            temp_Input = movementInput;
            target.position = Functions.f.V3toV2(transform.position) + (movementInput * movement_speed);
            transform.position = target.position;
            target.position = transform.position;
        }
        else if (!Input.anyKey)
        {
            target.position = transform.position;
            temp_Input = Vector2.zero;
        }

    }
}
