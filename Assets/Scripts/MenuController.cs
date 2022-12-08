using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public static int index;
    
    void Start()
    {
        
    }
    
    
    void Update()
    {
        
    }

    public void onButton1()
    {
        index = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void onButton2()
    {
        index = 1;
        SceneManager.LoadScene("SampleScene");
    }

    
}
