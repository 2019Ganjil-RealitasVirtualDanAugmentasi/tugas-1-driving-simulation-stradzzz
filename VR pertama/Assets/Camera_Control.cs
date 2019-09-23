using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public enum RotationAxis
    {
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxis axes = RotationAxis.MouseX;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    public float minimumHor = -45.0f;
    public float maximumHor = 45.0f;


    //sensitivity
    public float sensHorizontal = 10.0f; 
    public float sensVertical = 10.0f;

    //where player looking
    public float _rotationX;
    public float _rotationY;


    // Update is called once per frame
    void Update()
    {
        if(axes == RotationAxis.MouseX)
        {
            transform.Rotate (0, Input.GetAxis("Mouse X") * sensHorizontal, 0);
        } else if (axes == RotationAxis.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //set vertical angle within max an min limit (clamp)

            _rotationY = Input.GetAxis("Mouse X") * sensHorizontal;
            _rotationY = Mathf.Clamp(_rotationY, minimumHor, maximumHor); //set horizontal angle within max an min limit (clamp)


//            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3 (_rotationX, _rotationY, 0);
        }
    }
}
