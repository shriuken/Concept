using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEditor;

public class menuButtonNew : MonoBehaviour {

    public void NewGame(){
        Application.LoadLevel("Level1");
    }

    public void ExitGame()
    {
        if(EditorUtility.DisplayDialog("Exit the Game?", "Do you really want to exit this game?", "Exit Game", "Cancel")){
            Application.Quit();
        }
    }

}
