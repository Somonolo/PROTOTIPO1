using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text puntaje;
    public TMP_Text timer;
    
    public void UpdatePuntaje(int nuevopuntaje)
    {
        puntaje.text = "Puntaje: " + nuevopuntaje;
    }

    public void UpdateTimer(float newtime)
    {
        timer.text = "Tiempo: " + Mathf.Ceil(newtime);
    }

}
