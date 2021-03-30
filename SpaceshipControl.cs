using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour
{
     Rigidbody rb;
    float tilt = Mathf.Clamp(0, -45, 45);
   
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetAxis("Horizontal")!= 0)
        {
            if(Input.GetAxis("Horizontal")>0 && transform.position.x < 18.08)
            {
                transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * 20.0f);
                tilt = tilt - Time.deltaTime * 100;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, Mathf.Clamp(tilt, -45, 45)), 90);
            }
            if (Input.GetAxis("Horizontal") < 0 && transform.position.x > -18.2)
            {
                transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * 20.0f);
                tilt = tilt + Time.deltaTime * 100;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, Mathf.Clamp(tilt, -45, 45)), 90);
            }
        }
        
        else
        {
            if (tilt > 0)
            {
                tilt = tilt - Time.deltaTime * 100;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, Mathf.Clamp(tilt, -45, 45)), 90);
            }
            if (tilt < 0)
            {
                tilt = tilt + Time.deltaTime * 100;
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, Mathf.Clamp(tilt, -45, 45)), 90);
            }
        }

      
        
    }
    
}
