using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigraRotation : MonoBehaviour
{
    public GameObject sigraCenter;
    public float sigraWestwardSpeed;
    public float sigraEastwardSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.isDailyMotion && GameManager.Instance.shouldRotate && !GameManager.Instance.onlyManda && !GameManager.Instance.withoutMandaShigra){
            transform.RotateAround(sigraCenter.transform.position, Vector3.down, sigraWestwardSpeed * Time.deltaTime);
        }
        else if(GameManager.Instance.shouldRotate&&!GameManager.Instance.onlyManda&& !GameManager.Instance.withoutMandaShigra){
            transform.RotateAround(sigraCenter.transform.position, Vector3.down, sigraEastwardSpeed * Time.deltaTime);

        }
    }
}
