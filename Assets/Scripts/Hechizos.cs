using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    //Attributes
    public string hechizoName;
    public float poder;

    public GameObject prefabHechizo;
    public GameObject mago;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpellCasting() //Esta función estar enfocada en el comportamiento específico de cada hechizo: daño al enemigo, efectos especiales...
    {
        if (hechizoName== "DragonBreath")
        {
            Debug.Log("Has lanzado DragonBreath causando " + poder + "de damage!");
        }
        else if (hechizoName == "IcySpears")
        {
            Debug.Log("Has lanzado IcySpears causando " + poder + "de damage!");
        }
        else if (hechizoName == "FirefliesBlessing")
        {
            Instantiate(prefabHechizo, transform.position, Quaternion.identity);
            mago.GetComponent<Mago>().RecargarMana(poder);
            Debug.Log("Has usado FirefliesBlessing recuperando " + poder + "de maná!");
        }
        else
        {
            Debug.Log("Algo no va bien... no estás lanzando hechizos!");
        }

        Instantiate(prefabHechizo, transform.position, Quaternion.identity);
        Debug.Log("Has usado " + hechizoName + " causando " + poder + "p de daño!");
    }

    public void MostrarNombre()
    {
        Debug.Log("Nombre del hechizo: " + hechizoName);
    }
}
