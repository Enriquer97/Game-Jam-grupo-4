using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnOnePlay()
    {
        
        SceneManager.LoadScene(1);
    }
    public void OnOneExit()
    {

        Application.Quit(); 
    }
}
