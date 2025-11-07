using UnityEngine;

public class MOVINGPLATFORM : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public float t;
    public int d=1;
    public float time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(p1.transform.position , p2.transform.position, t/time);
        t += Time.deltaTime*d;
        if (t > time)
        {
            d = -1;

        }

        if (t < 0)
        {
            d = 1;

        }



    }
    
}
