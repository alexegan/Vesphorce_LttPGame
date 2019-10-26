using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Author: AlexEgan
 * 
 * Currently, this is just pilfered from a previous project to get something working for now.
 */
public class _script_PlayerMovement_v01 : MonoBehaviour
{
    public float MovementSpeed = 5f;
    public float DiagonalMoveSpeedMultiplier = 1f;


    public float horizontal, vertical;
    Rigidbody2D Body;



    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody2D>();
        Body.freezeRotation = true;
    }

    private void MovePlayer()
    {

        Vector2 pos = Body.velocity;
        if (vertical != 0)
        {
            pos.y = MovementSpeed * Mathf.Sign(vertical);
        }
        else
        {
            pos.y = 0;
        }
        if (horizontal != 0)
        {
            pos.x = MovementSpeed * Mathf.Sign(horizontal);
        }
        else
        {
            pos.x = 0;
        }
        if (vertical != 0 && horizontal != 0)
        {
            //float average = Mathf.Sqrt(MovementSpeed);
            float average = Mathf.Sqrt(Mathf.Pow(horizontal, 2) + Mathf.Pow(vertical, 2));
            pos.x = average * MovementSpeed * Mathf.Sign(horizontal);
            pos.y = average * MovementSpeed * Mathf.Sign(vertical);
        }

        Body.velocity = pos;
        return;
    }


    private void FixedUpdate()
    {
        {
            MovePlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            horizontal = 0;
        }
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            vertical = Input.GetAxisRaw("Vertical");
        }
        else
        {
            vertical = 0;
        }
    }






}
