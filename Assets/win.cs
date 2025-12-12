using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    public void menubutton()
    {
        SceneManager.LoadScene(2);


    }
    public void quitbutton()
    {
        Application.Quit();

        
    }
    public void restartbutton()
    {
        SceneManager.LoadScene(0);


    }
    public void itdoesnothing()
    {
        // it does nothing
    }


}
