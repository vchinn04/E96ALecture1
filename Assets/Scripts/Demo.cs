using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + new Vector3(0,10,0);
        
        Debug.Log("Instance Created!");
        Debug.Log(transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
