using UnityEngine;

public class hover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.linearVelocity = Vector3.zero;
        other.attachedRigidbody.useGravity = false;

    }
    private void OnTriggerStay(Collider other)
    {
        //other.attachedRigidbody.AddForce(transform.up * 1, ForceMode.VelocityChange);
        other.attachedRigidbody.AddForce(transform.forward * 1, ForceMode.VelocityChange);
        
    }
    private void OnTriggerExit(Collider other)
    {
        other.attachedRigidbody.linearVelocity = Vector3.zero;
        other.attachedRigidbody.useGravity = true;
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
