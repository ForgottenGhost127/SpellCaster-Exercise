using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewards : MonoBehaviour
{
    public string hechizoName;

    public Hechizos hechizoPrefab;
    public Mago mago;
    public LibroHechizos spellBook;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            spellBook.AprenderHechizo(hechizoName);
            //mago.AgregarSpell(hechizoPrefab);

            Destroy(gameObject);
        }
    }
}
