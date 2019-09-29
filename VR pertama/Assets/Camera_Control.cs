using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{

    public float minimumVert = -25.0f;
    public float maximumVert = 25.0f;
    public float minimumHor = -80.0f;
    public float maximumHor = 80.0f;


    //sensitivity
    public float sensHorizontal = 5.0f; 
    public float sensVertical = 5.0f;

    //where player looking
    public float _rotationX;
    public float _rotationY;


    // Update is called once per frame
    void Update()
    {
   
            _rotationX -= Input.GetAxis("Mouse Y") * sensVertical;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert); //set vertical angle within max an min limit (clamp)

            _rotationY -= Input.GetAxis("Mouse X") * sensHorizontal;
            _rotationY = Mathf.Clamp(_rotationY, minimumHor, maximumHor); //set horizontal angle within max an min limit (clamp)


            transform.localEulerAngles = new Vector3(_rotationX, -_rotationY, 0);
        
    }
}
