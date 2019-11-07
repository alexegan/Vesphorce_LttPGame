using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// TODO: Write description of what a focus point is
/// </summary>
public class _script_FocusPointLogic : MonoBehaviour
{
    public int DebugLevel = 3;

    private SpriteRenderer AttachedSprite;
    private GameObject Attached;
    public Vector2 Range = new Vector2(50f, 50f);

    private void Awake()
    {
        Attached = gameObject;
        if (!Attached.tag.Equals("FocusPoint"))
            Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        AttachedSprite = Attached.GetComponentInChildren<SpriteRenderer>();

        if (AttachedSprite != null)
        {
            AttachedSprite.transform.localScale = Range;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (AttachedSprite != null)
        {
	        AttachedSprite.enabled = PlayerPrefs.GetInt("DebugMode") > DebugLevel;
        }
    }


}
