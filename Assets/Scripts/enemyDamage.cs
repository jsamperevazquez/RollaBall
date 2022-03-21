using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
  public GameObject looseTextObject;

  private void Start()
  {
    looseTextObject.SetActive(false);
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Enemy"))
    {
      Debug.Log("Jugador atrapado por enemigo");
      gameObject.SetActive(false);
      looseTextObject.SetActive(true);
    }
  }
}
