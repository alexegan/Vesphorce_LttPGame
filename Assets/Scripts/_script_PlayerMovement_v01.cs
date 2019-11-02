using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;


/**
 * Author: AlexEgan
 * 
 * Currently, this is just pilfered from a previous project to get something working for now.
 */
public class _script_PlayerMovement_v01 : MonoBehaviour
{
    public float MovementSpeed = 5f;
    public float DiagonalMoveSpeedMultiplier = 1f;

    private Vector2 m_Movement;
    private Vector2 m_Facing;

    public float horizontal, vertical;
    Rigidbody2D Body;


    // Start is called before the first frame update
    void Start()
    {
        Body = GetComponent<Rigidbody2D>();
        Body.freezeRotation = true;
    }

    /*
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
    */


    /**
     * Uses m_Movement
     */
    private void MovePlayer()
    {

        Vector2 pos = Body.velocity;
        if (m_Movement.y != 0)
        {
            pos.y = MovementSpeed * Mathf.Sign(m_Movement.y);
        }
        else
        {
            pos.y = 0;
        }
        if (m_Movement.x != 0)
        {
            pos.x = MovementSpeed * Mathf.Sign(m_Movement.x);
        }
        else
        {
            pos.x = 0;
        }
        if (m_Movement.x != 0 && m_Movement.y != 0)
        {
            float average = (Mathf.Sqrt(m_Movement.x * m_Movement.x + m_Movement.y * m_Movement.y));
            pos.x = MovementSpeed * (m_Movement.x / average);
            pos.y = MovementSpeed * (m_Movement.y / average);
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
        /*
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
        }*/
    }



    /* INPUT SYSTEM */

    /**
     * Attached to the player is a "Player Input (Script)" component that has a submenu of Events.
     * 
     * Additionally, there's an Action Map asset called "_inputaction_PlayerInput" (That does NOT have the C# script icon in the Project folder).
     * 
     * In the Action Map, you can create Actions that look for a specific kind of action (like a button press or a joystick axis moving). Under these
     * actions, you can create Bindings (a newly created Action comes with one by default). These Bindings read what button or axis you want to read 
     * (like "Button East [GamePad]" for any controller's rightmost face button). The Interaction submenu here lets you define what specific part
     * of the binding's action will be read (such as "Press Only" or "Release Only" for specific parts of the action).
     * 
     * You can bind multiple bindings to a single Action - such as keyboard AND controller input to "input_Button_Lower" - and they all funnel into
     * the same Action.
     * 
     * That "Player Input (Script)" component with a submenu of Events mentioned earlier is where you define how things react to these inputs.
     * 
     * Under the Events submenu (and possibly under the submenu below it), you'll see all the Actions you defined. Here, you can tell this component
     * [What object] is listening for these inputs, and [What function] it should call whenever that action is fired.
     * 
     * Below are the functions currently set up to handle input for this player.
     */

    /**
     * Called when the Dpad (or equivalent) is pressed.
     */
    public void OnInput_Movement(InputAction.CallbackContext context)
    {
        m_Movement = context.ReadValue<Vector2>();
    }

    /**
     * Called when the lower face button (or equivalent) is pressed.
     */
    public void OnInput_Button_Lower(InputAction.CallbackContext context)
    {
        // This code is copied from the example code, and demonstrates how to do a charging mechanic
        // I've commented out the stuff we don't use right now.

        switch (context.phase)
        {
            case InputActionPhase.Performed:
                if (context.interaction is SlowTapInteraction)
                {
                    //StartCoroutine(BurstFire((int)(context.duration * burstSpeed)));
                }
                else
                {
                    //Fire();
                }
                //m_Charging = false;
                break;

            case InputActionPhase.Started:
                if (context.interaction is SlowTapInteraction)
                {
                    //m_Charging = true;
                }
                break;

            case InputActionPhase.Canceled:
                //m_Charging = false;
                break;
        }
    }

}
