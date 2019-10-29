using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _script_CameraMovement : MonoBehaviour
{
    [Tooltip("Scales all camera values by this amount for uniform resizing.")]
    public float CameraSettingsScale = 5f;
    [Tooltip("The default zoom value of the camera.")]
    public float CameraZoomDefault = 1f;
    [Tooltip("The rough offset granted between Focus Points and the border of the camera.")]
    public float CameraZoomOffset = 1f;
    [Tooltip("The minimum value the camera can zoom in by.")]
    public float CameraZoomDefaultMin = 1f;
    [Tooltip("The maximum value the camera can zoom out by.")]
    public float CameraZoomDefaultMax = 5f;
    [Tooltip("How much more camera padding the Player is given when determining the camera's movement.")]
    [Range(1, 100)]
    public float PlayerWeight = 1f;



    private Camera camera;
    private Dictionary<int, _script_FocusPointLogic> FocusPoints;
    private GameObject Player;

    private void Awake()
    {
        // This script must be attached to a camera object.
        camera = gameObject.GetComponent<Camera>();
        if (camera == null)
        {
            Destroy(this.gameObject);
            Debug.Log("Camera Controller script must be attached to a camera");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        FocusPoints = new Dictionary<int, _script_FocusPointLogic>();
        Player = GameObject.FindGameObjectWithTag("Player");
        // TODO: Figure out how to define focus points better.
        GameObject[] focusObject = GameObject.FindGameObjectsWithTag("camera_FocusPoints");


        if (Player == null)
        {
            Debug.Log("Cannot find Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            List<Vector2> input = new List<Vector2>();
            input.Add(Player.transform.position);
            if (PlayerWeight > 1)
            {
                Vector2 weightedPos = Player.transform.position;
                float pWeight = ((PlayerWeight) / 10f);
                input.Add(new Vector2(weightedPos.x + pWeight, weightedPos.y + pWeight));
                input.Add(new Vector2(weightedPos.x - pWeight, weightedPos.y + pWeight));
                input.Add(new Vector2(weightedPos.x + pWeight, weightedPos.y - pWeight));
                input.Add(new Vector2(weightedPos.x - pWeight, weightedPos.y - pWeight));
            }
            CameraMovement(input);
        }
    }




    /*
     * Reads the list of points of focus the camera is based upon.
     * 
     * Input list is the list of dynamic objects that change frequently.
     * TODO: fix how the input vectors are determined.
     */
    private void CameraMovement(List<Vector2> AdditionalFocusPoints)
    {
        float cam_size, x_dist_min, x_dist_max, y_dist_min, y_dist_max, x_dist, y_dist;
        
        // TODO: Set up system to allow for additional focus points.

        x_dist_min = y_dist_min = 10000f;
        x_dist_max = y_dist_max = -10000f;
        // Move the camera so that it's focused on the center of the focus points.
        foreach (Vector2 point in AdditionalFocusPoints)
        {
            // min/max distance between points
            if (x_dist_min > point.x)
                x_dist_min = point.x;
            if (x_dist_max < point.x)
                x_dist_max = point.x;
            if (y_dist_min > point.y)
                y_dist_min = point.y;
            if (y_dist_max < point.y)
                y_dist_max = point.y;
        }

        cam_size = 0;
        x_dist = (x_dist_max - x_dist_min) * (9f / 16f);
        y_dist = (y_dist_max - y_dist_min);

        camera.transform.position = new Vector3(((x_dist_max + x_dist_min) / 2), ((y_dist_max + y_dist_min) / 2), -10);
        if ((x_dist) > (y_dist))
            cam_size = x_dist;
        else
            cam_size = y_dist;

        cam_size += CameraZoomOffset;
        cam_size /= 2;

        if (cam_size < CameraZoomDefaultMin)
        {
            cam_size = CameraZoomDefaultMin;
        }
        if (cam_size > CameraZoomDefaultMax)
        {
            cam_size = CameraZoomDefaultMax;
        }

        camera.orthographicSize = cam_size * CameraSettingsScale;
        return;
    }

}
