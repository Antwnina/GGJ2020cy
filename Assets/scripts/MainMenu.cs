using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour {

    //public Button btnNew;
    //public Button btnLoad;
    //public Button btnQ;
    
    public string newGameSceneName;
    
    public GameObject loadGameMenu;
    
    public void btnNew()
    {
        //SceneManager.LoadScene(newGameSceneName);
        SceneManager.LoadScene(0);
    }
    
    public void btnLoad()
    {
        loadGameMenu.SetActive(true);
    }

    public void btnQ()
    {
        Application.Quit();
    }

}
