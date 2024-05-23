// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Angle : MonoBehaviour
// {
//     public GameObject referenceObject;
//     public GameObject object1;
//     public GameObject object2;
//     public float rotationAngle;
//     // Start is called before the first frame update
//     void Start()
//     {
//         Vector3 referencePoint=referenceObject.transform.position;
//         Vector3 point1=object1.transform.position;
//         Vector3 point2=object2.transform.position;

//         Vector3 direction1=point1-referencePoint;
//         Vector3 direction2=point2-referencePoint;
//         direction1.y=0;
//         direction2.y=0;
//         float angle=Vector3.Angle(direction1,direction2);
//         Debug.Log("The direction is"+direction2);
//         object2.transform.RotateAround(object1.transform.position,Vector3.up,30);
//         // Quaternion newRotation = Quaternion.Euler(0f, angle, 0f);
//         // object2.transform.rotation = referenceObject.transform.rotation * newRotation;

//         Debug.Log("The angle between the starting point and sun is"+angle);
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
