using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateModle : MonoBehaviour
{
    public Transform modelTransform;
    private bool isRotate;
    private Vector3 startPoint; 
    private Vector3 startAngel; 
    [Range(0.1f, 1f)]
    public float rotateScale = 1f; 

    void Start()
    {

    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !isRotate)
        {
            isRotate = true;
            startPoint = Input.mousePosition; 
            startAngel = modelTransform.eulerAngles; 
        }
        if (Input.GetMouseButtonUp(0))
        {
            isRotate = false; 
        }
        if (isRotate)
        {
            var currentPoint = Input.mousePosition; 
            
            var x = startPoint.x - currentPoint.x;
            modelTransform.eulerAngles = startAngel + new Vector3(0, x * rotateScale, 0);
            
            //var y = startPoint.y + currentPoint.y;
            //modelTransform.eulerAngles = startAngel + new Vector3(y * rotateScale, 0, 0);

            //var z = startPoint.z - currentPoint.z;
            //modelTransform.eulerAngles = startAngel + new Vector3(0, 0, z * rotateScale);
        }
    }
}
