using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 40;
        myStyle.normal.textColor = Color.red;

        GUI.Label(new Rect(50, 50, 100, 20),
            "Pontos: " + PlayerShot.pontos, myStyle);
    }
}
