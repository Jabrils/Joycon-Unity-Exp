using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camCam : MonoBehaviour
{
    
    public GameObject follow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.transform.position + new Vector3(0, 2, -5);
        transform.LookAt(follow.transform);
    }
}
