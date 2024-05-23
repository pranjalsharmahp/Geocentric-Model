using UnityEngine;

//Attach this script to a GameObject to rotate around the center position.
public class Example : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject center;
    public float westwardSpeed;
    public float eastwardSpeed;
    public double lagAngle;
    public double dailyAngle;
    public GameObject Axis;
    public Quaternion initialRotation;
    
    
    void Start(){
        // Debug.Log("The dailyangle "+dailyAngle*714404168578.127000);
        // lagAngle=(dailyAngle*714404168578.127000)%360;
        // Debug.Log("The lag angle is"+lagAngle);
        // transform.RotateAround(center.transform.position, Vector3.down, (float)lagAngle);
        Axis=GameObject.Find("The axis");
        initialRotation=transform.rotation;

        
        
        
    }
    void Update()
    {
        
        Vector3 relativePos=transform.position-center.transform.position;
        Quaternion rotation=Quaternion.LookRotation(-relativePos, Vector3.up);
        rotation = Quaternion.Euler(0, rotation.eulerAngles.y, 0);
        transform.rotation=rotation;
        // Spin the object around the center at 20 degrees/second.
        
        if(GameManager.Instance.isDailyMotion && GameManager.Instance.shouldRotate){
            transform.RotateAround(center.transform.position, Axis.transform.position, westwardSpeed * Time.deltaTime);
        }
        else if(GameManager.Instance.shouldRotate){
            
            transform.RotateAround(center.transform.position,new Vector3(+0.4067f,-0.9135f,0), eastwardSpeed * Time.deltaTime);
        }
        else{
            
        }
        // transform.rotation=initialRotation;
    }
}