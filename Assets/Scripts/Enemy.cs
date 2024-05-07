using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float saludActual;
    public float saludMaxima = 300f;
    // Start is called before the first frame update
    void Start()
    {
        saludActual = saludMaxima;
    }

    public void GetDamaged(float damage)
    {
        saludActual -= damage;
        if (saludActual <= 0)
        {
            GetOwned();
        }

    }

    void GetOwned()
    {
        Debug.Log("Enemy destroyed");
        Destroy(gameObject);
    }
}
