using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class menuButtonHandlers : MonoBehaviour {

    public void NewGame()
    {
        Application.LoadLevel("Level1");
    }

    public void ExitGame()
    {
        quit = !quit;
    }

    public void LoadGame()
    {

    }

public bool quit  = false;

    void OnGUI()
    {
        if (quit)
        { 
            GUI.Label(new Rect(638, 600, 200, 100), "Would You like to quit the game?");
            if (GUI.Button(new Rect(628, 630, 100, 100), "Yes"))
            {
                Application.Quit();
            }
            if (GUI.Button(new Rect(738, 630, 100, 100), "No"))
            {
                quit = false;
            }
        }
    }
}

