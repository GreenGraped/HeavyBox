using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    Vector2 input;
    Transform target;
    [SerializeField] bool input_exist;
    void Start()
    {
        input_exist = false;
        target = transform.Find("to_move");
    }

    // Update is called once per frame
    void Update()
    {
        /* input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (input == Vector2.zero)
        {
            transform.Find("to_move").position = transform.position;
        } else
        {
            transform.Find("to_move").position = Functions.f.V3toV2(transform.position) + input;
        } */

        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (input != Vector2.zero && !input_exist)
        {
            if (input.x != 0 && input.y != 0)
            {
                input.x = 0;
            }
            target.position = Functions.f.V3toV2(transform.position) + input;
            input_exist = true;
        } else if (input == Vector2.zero && input_exist)
        {
            target.position = transform.position;
            input_exist = false;
        }
    }
}
