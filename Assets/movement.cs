using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = new Vector3(-1, 0, 0);
       
        transform.position += new Vector3(-1, 0, 0);

    }
}
