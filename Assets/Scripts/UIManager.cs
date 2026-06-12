using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text puntaje;
    public TMP_Text timer;
    public GameObject panelGameOver;
    public GameObject panelGanaste;

    void Start()
    {
        panelGameOver.SetActive(false);
        panelGanaste.SetActive(false);
    }

    public void UpdatePuntaje(int nuevopuntaje)
    {
        puntaje.text = "Puntaje: " + nuevopuntaje;
    }

    public void UpdateTimer(float newtime)
    {
        timer.text = "Tiempo: " + Mathf.Ceil(newtime);
    }

    public void MostrarGameOver()
    {
        panelGameOver.SetActive(true);
    }

    public void MostrarGanaste()
    {
        panelGanaste.SetActive(true);
    }
}