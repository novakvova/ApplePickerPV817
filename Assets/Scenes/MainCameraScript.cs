using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainCameraScript : MonoBehaviour
{
    public Dropdown m_Dropdown;
    public int m_DropdownValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickButtonStart()
    {
        string text = m_Dropdown.options[m_Dropdown.value].text;
        if (text == "Hard")
        {
            ApplePicker.level = 2.5f;
            ApplePicker.appleSpeed = 0.35f;
        }
        if (text == "Middle")
        {
            ApplePicker.level = 1.5f;
            ApplePicker.appleSpeed = 0.55f;
        }
        if (text == "Easy")
        {
            ApplePicker.level = 1f;
            ApplePicker.appleSpeed = 1.1f;
        }
        SceneManager.LoadScene("_Scene_0");
    }
}
