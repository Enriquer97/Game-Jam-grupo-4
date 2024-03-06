using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 dir = new Vector3 (0f, 1f, 0f);
        Debug.DrawRay(transform.position, dir * 1000 , Color.red, 0, false);
    }
}
