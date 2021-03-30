using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateMissile : MonoBehaviour
{
    public GameObject missile;
    float time;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
      
                Vector3 position = new Vector3(transform.position.x, -3.0f, transform.position.z);
                Instantiate(missile, position, transform.rotation);

          
        }
    }
}
