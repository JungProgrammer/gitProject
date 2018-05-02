using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public bool isPause;
    public GameObject MenuPanel;


    private void Start()
    {
        Time.timeScale = 1;
        isPause = false;
        MenuPanel.SetActive(false);
    }

    void Update () {
		
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(!isPause)
            {
                Time.timeScale = 0;
                isPause = true;
                MenuPanel.SetActive(true);
            }

            else
            {
                Time.timeScale = 1;
                isPause = false;
                MenuPanel.SetActive(false);
            }
        }

	}

    public void OffPause()
    {
        Time.timeScale = 1;
        isPause = false;
        MenuPanel.SetActive(false);
    }

    public void loadMenu()
    {
        Application.LoadLevel(0);
    }
}
