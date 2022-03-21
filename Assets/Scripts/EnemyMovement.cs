using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float rangoVision; // Rango de alerta del enemigo (radio de la esfera virtual)

    public LayerMask capaPlayer; // Capa que contiene al player para comprobar si entra en la esfera

    private bool estarAlerta; // variable para asignar la posición exacta del jugador

    public Transform player;

    public float velocidadEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar presencia de player para perseguirlo
        // esta función crea una esfera alrededor de personaje en la cual se comprueba si hay objetos dentro de ella
       estarAlerta = Physics.CheckSphere(transform.position,rangoVision,capaPlayer);
       if (estarAlerta)
       {
           //Debug.Log("Jugador entró en radio de enemigo");
           transform.LookAt(player);
           transform.position = Vector3.MoveTowards(transform.position, player.position, velocidadEnemigo * Time.deltaTime);
       }
    }

    // Función para poder visualizar diferentes aspectos como el radio alerta enemigo 
    private void OnDrawGizmos()
    {
        // Dibujamos la esfera para poder ver en tiempo real el radio de alerta
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position,rangoVision);
    }
}
