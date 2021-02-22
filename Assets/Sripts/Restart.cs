using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EzModeBtn() 
    {
        SceneManager.LoadScene(4);
    }

    public void HardcoreBtn()
    {
        SceneManager.LoadScene(1);
    }

    public void StartMenu() 
    {
        SceneManager.LoadScene(0);
    }
}
