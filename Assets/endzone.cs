using UnityEngine;
using UnityEngine.SceneManagement;

public class endzone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // end is restarting the game i think
    public void End()
    {
        SceneManager.LoadScene(1);

    }

    private void OnTriggerEnter(Collider other)
    {
        End();
    }
    


}
