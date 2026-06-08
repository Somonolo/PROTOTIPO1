using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollisionObjetoYPuntuacion : MonoBehaviour
{
    public int recolectados = 0;
    private UIManager uiManagerScript;
    
     void Start()
    {
        uiManagerScript = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            recolectados = recolectados + 1;
            uiManagerScript.UpdatePuntaje(recolectados);
        }
    }
}
