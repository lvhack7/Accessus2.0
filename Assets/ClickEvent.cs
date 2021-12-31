using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickEvent : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (button.name == "Police")
        {
            SceneManager.LoadScene("PoliceScene");
        }
        else if (button.name == "Fire")
        {
            SceneManager.LoadScene("FireScene");
        }
        else if (button.name == "Help")
        {
            SceneManager.LoadScene("HelpScene");
        }

        Debug.Log(button.name);
    }
}
