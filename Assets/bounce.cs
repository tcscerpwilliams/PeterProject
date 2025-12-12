using Unity.VisualScripting;
using UnityEngine;

public class bounce : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.AddForce(transform.up*10,ForceMode.Impulse);
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
