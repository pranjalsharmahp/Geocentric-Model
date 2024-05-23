using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MandaRotation : MonoBehaviour
{
    public GameObject mandaCenter;
    public Quaternion lockedRotation = Quaternion.identity;

    public float mandaEastwardSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.rotation=lockedRotation;
        if(!GameManager.Instance.withoutMandaShigra && !GameManager.Instance.isDailyMotion){
            transform.RotateAround(mandaCenter.transform.position, Vector3.down, mandaEastwardSpeed * Time.deltaTime);
        }
        
               
    }
}
