using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObjetoYPuntuacion : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
        }
    }
}
