using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///	A super-quick example class to show some of the built-in methods Unity has for us to work with.
/// </summary>
public class _script_Testing : MonoBehaviour
{
    /**
     * In Unity, you can create and define public variables that can be seen in Unity's Inspector.
     * This is great for fine-tuning things like move speed and damage values, or any other thing you might want to easily modify.
     * (Especially if you have multiple objects that use the same script, and you want to vary things like move speed or size.)
     * 
     * These values can even be changed in the inspector while the game is playing, though those modifications are not saved when
     * the game is stopped.
     */
    public int TestInteger = 2;
    public float DemoFloat = 1.4f;

    // You can easily find guides on how to modify Inspector settings to your whims.

    /// <summary>
    ///	If you want to do simple drop-down boxes in the inspector, that's done through enums.
	///	In this example, I defined three options for a bomb's explosion pattern.
    /// </summary>
	public enum SpreadType
    {
        Plus,
        Circle,
        Spot
    };
    public SpreadType FireSpreadType = SpreadType.Plus;

    /// <summary>
    ///	Awake is called before Start. If you want to ensure things are ready (like a certain object exists) before you
	///	initialize any values for those objects, you'll likely want to check that in Awake.
    ///	Singleton behavior is also often done here - so if we only want to have one object with this script in the scene,
	///	this is the common place to do it.
    /// </summary>
    private void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {

	}

    /// <summary>
    /// FixedUpdate fires on 1/50 second intervals. This is what built-in physics engine uses for it's updates.
    /// </summary>
	private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

	}

    /// <summary>
    /// LateUpdate is called at the end of every frame.
	/// I hear this is great for UI
    /// </summary>
	private void LateUpdate()
    {
        
    }



    /**
     * When this object comes in contact with another object whose collider IS a trigger, they will interact like
     * damage boxes or trigger zones for events.
     */

    /**
     * Enter: The first contact
     * Stay: While in contact
     * Exit: When they no longer are colliding
     * 
     * The collision variable can let you extract what kind of gameobject the trigger zone is.
     */


	private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }


    /**
     * When this object collides with another gameobject with a collider, and that collider is NOT marked as a Trigger,
     * they will bump into each other and collide like two apples hitting each other.
     * This is where you'll want to handle those situations
     */

    /**
     * Enter: The first contact
     * Stay: While in contact
     * Exit: When they no longer are colliding
     * 
     * The collision variable can let you extract what kind of gameobject is being collided with.
     */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
}
