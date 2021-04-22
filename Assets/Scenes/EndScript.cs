using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickReloadGame()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }
}
