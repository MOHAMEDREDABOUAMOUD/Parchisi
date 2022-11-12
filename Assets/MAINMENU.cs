using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MAINMENU : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("MENU 2");
    }
    
    public void playgame1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void playgame2()
    {
        SceneManager.LoadScene("3PLAYERS");
    }

    public void playgame3()
    {
        SceneManager.LoadScene("4PLAYERS");
    }

    public void quitgame()
    {
        Application.Quit();
    }

    public void backmenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void backmenu2()
    {
        SceneManager.LoadScene("menu 2");
    }
}
