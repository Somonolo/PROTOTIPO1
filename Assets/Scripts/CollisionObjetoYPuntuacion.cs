using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjetoYPuntuacion : MonoBehaviour
{
    public int recolectados = 0;
    public int totalObjetivos = 5;
    private UIManager uiManagerScript;
    private GameManager gameManager;

    void Start()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            recolectados++;
            uiManagerScript.UpdatePuntaje(recolectados);

            if (recolectados >= totalObjetivos)
            {
                gameManager.GanarJuego();
            }
        }
    }
}