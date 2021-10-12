using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{

    public Vector3 offset;
    public GameObject follow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = follow.transform.position.x;
        float posZ = follow.transform.position.z;

        transform.position = new Vector3(posX - 30, transform.position.y , posZ);
    }
}
