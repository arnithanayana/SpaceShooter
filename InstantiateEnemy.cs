using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{

    public GameObject enemy;
    float time;
    
    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 8)
        {
            float randomX = Random.Range(-17.0f, 17f);
            Instantiate(enemy, new Vector3(randomX, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(enemy, new Vector3(randomX, transform.position.y, transform.position.z + 4.0f), transform.rotation);
            Instantiate(enemy, new Vector3(randomX, transform.position.y, transform.position.z + 7.0f), transform.rotation);
            time = 0;
        }

    }
}
