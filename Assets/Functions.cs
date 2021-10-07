using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(@"Scenes/Level1");
    }

    public void OnExit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(@"Scenes/MainMenu");
    }
}
