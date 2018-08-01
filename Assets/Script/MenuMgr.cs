using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject InGameMenu;
    public GameObject HowToPlay;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartAR()
    {
        MainMenu.SetActive(false);
        HowToPlay.SetActive(false);

        InGameMenu.SetActive(true);

    }

    public void OpenHowToPlay()
    {
        MainMenu.SetActive(false);
        HowToPlay.SetActive(true);
        InGameMenu.SetActive(false);
    }

    public void BackToMainMenu()
    {
        MainMenu.SetActive(true);
        HowToPlay.SetActive(false);
        InGameMenu.SetActive(false);
    }

    public void PlayVideoSejarah()
    {
        Handheld.PlayFullScreenMovie("VideoSejarah.mp4");
    }

    public void PlayVideoRevitalisasi()
    {
        Handheld.PlayFullScreenMovie("VideoRevitalisasi.mp4");
    }

	public void QuitApplication()
	{
		Application.Quit();
	}
}
