using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private bool juegoTerminado = false;
    private UIManager uiManager;
    private CollisionObjetoYPuntuacion colision;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        colision = FindObjectOfType<CollisionObjetoYPuntuacion>();
    }

    void Update()
    {
        if (juegoTerminado) return;

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;
            juegoTerminado = true;
            uiManager.UpdateTimer(timer);
            TerminarJuego();
            return;
        }

        uiManager.UpdateTimer(timer);
    }

    void TerminarJuego()
    {
        if (colision.recolectados >= 5)
            uiManager.MostrarGanaste();
        else
            uiManager.MostrarGameOver();
    }

    public void GanarJuego()
    {
        juegoTerminado = true;
        uiManager.MostrarGanaste();
    }
}