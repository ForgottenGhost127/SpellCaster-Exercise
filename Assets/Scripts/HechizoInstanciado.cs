using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HechizoInstanciado : MonoBehaviour
{
    public float poder;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.GetDamaged(poder);
                Debug.Log("Enemy hit by spell with power " + poder);
            }

        }
    }
}
