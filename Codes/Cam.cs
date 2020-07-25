using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 40;
        myStyle.normal.textColor = Color.red;

        GUI.Label(new Rect(50, 50, 100, 20), 
            "Pontos: " + Player.pontos, myStyle);
    }
}
