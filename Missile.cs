using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Rigidbody rb;
    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * 20, ForceMode.Impulse);
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "nave(Clone)")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            Instantiate(particle, transform.position, transform.rotation);
            particle.Stop();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
