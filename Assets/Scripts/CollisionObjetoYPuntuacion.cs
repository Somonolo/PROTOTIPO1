using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjetoYPuntuacion : MonoBehaviour
{
    private int puntaje = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            puntaje++;
            Debug.Log("¡Objeto encontrado! Puntaje: " + puntaje);
            Destroy(other.gameObject);
        }
    }
}
