using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody body;
    public float speed;
    public float jumpforce;
   
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = 0;
        int z = 0;
        if (Input.GetKey(KeyCode.W))
        {
            z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }


        var direction = new Vector3(x, 0, z);


        transform.position += direction * Time.deltaTime * speed;

        if (Input.GetKeyDown(KeyCode.Space) &&body.linearVelocity.y==0)
        {
            body.AddForce(Vector3.up * jumpforce);
        }
        


    }

    private void OnCollisionEnter(Collision collision)
    {
        var p=collision.gameObject.GetComponent<MOVINGPLATFORM>();
        if (p != null)
        {
            
        }
        transform.parent = collision.transform;
    }
}
