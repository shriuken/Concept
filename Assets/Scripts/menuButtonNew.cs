using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class menuButtonNew : MonoBehaviour {

    public void NewGame(){
        Application.LoadLevel("Level1");
    }

}
