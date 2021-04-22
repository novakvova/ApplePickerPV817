using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainCamerScripts : MonoBehaviour
{
    public Button btnStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClickButtonStart()
    {
        SceneManager.LoadScene("_Scene_0");
    }
}
