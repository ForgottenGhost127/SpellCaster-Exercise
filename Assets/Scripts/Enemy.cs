using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float saludActual;
    public float saludMaxima = 300f;

    public float speedMovement = 3f;
    public float rangoDeteccion = 10f;

    public Transform player;
    
    public GameObject rewardPref;
    public Vector3 rewardSpawnOffset = Vector3.zero;

    private bool isDestroyed = false;

    void Start()
    {
        saludActual = saludMaxima;

        player = GameObject.FindWithTag("Player").transform;
        
    }

    void Update()
    {
        if (player != null && Vector3.Distance(transform.position, player.position) <= rangoDeteccion)
        {
            MoverHaciaPlayer();
        }
    }

    void MoverHaciaPlayer()
    {
        Vector3 direccion = (player.position - transform.position).normalized;
        transform.Translate(direccion * speedMovement * Time.deltaTime, Space.World);
       
    }

    public void GetDamaged(float damage)
    {
        saludActual -= damage;
        if (saludActual <= 0 && !isDestroyed)
        {
            GetOwned();
        }

    }

    void GetOwned()
    {
        if (isDestroyed) return;
        isDestroyed = true;
        Debug.Log("Enemy destroyed: " + gameObject.name);
        
        

        if (rewardPref != null)
        {
            
            Vector3 rewardPosition = transform.position + rewardSpawnOffset;
            Instantiate(rewardPref, rewardPosition, Quaternion.identity);
        }

        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            print("Ha habido colision.");
        }
    }
}
