using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHelper : MonoBehaviour {

    public Text Score;
    public GameObject infoPanel;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Score.text = Score.text +" " +  PlayerPrefs.GetInt("Score").ToString();
    }

    public void LoadGame()
    {
        Application.LoadLevel(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Info()
    {
       if(!infoPanel.activeSelf)
        {
            infoPanel.SetActive(true);
        }
       else
        {
            infoPanel.SetActive(false);
        }
    }
}
