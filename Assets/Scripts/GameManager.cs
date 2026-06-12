using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float timer = 60f;
    private bool juegoTerminado = false;
    private UIManager uiManager;
    private CollisionObjetoYPuntuacion colision;

    public KeyCode teclaReiniciar = KeyCode.R;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        colision = FindObjectOfType<CollisionObjetoYPuntuacion>();
    }

    void Update()
    {
        if (juegoTerminado)
        {
            if (Input.GetKeyDown(teclaReiniciar))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            return;
        }

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