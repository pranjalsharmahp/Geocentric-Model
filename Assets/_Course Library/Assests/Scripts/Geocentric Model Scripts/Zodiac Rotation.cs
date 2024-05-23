using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZodiacRotation : MonoBehaviour
{
    public float westwardSpeed;
    public GameObject center;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (GameManager.Instance.isDailyMotion){
            transform.RotateAround(center.transform.position,Vector3.up,westwardSpeed*Time.deltaTime);
        }
        
    }
}
