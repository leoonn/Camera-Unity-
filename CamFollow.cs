using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player;
    public float speedSmooth = 0.3f; 
    public Vector3 offset; //can be config on inspector 

    
    
    void LateUpdate() //LateUpdate is called after all Update functions have been called.
    {
        Vector3 CamPosition = player.position + offset; 
        Vector3 smoothposition = Vector3.Lerp(transform.position, CamPosition, speedSmooth); //Interpolates between the points and by the interpolant .
        transform.position = smoothposition;
    }
}
