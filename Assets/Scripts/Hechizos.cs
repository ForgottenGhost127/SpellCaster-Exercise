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

    public void SpellCasting() //Esta funci�n estar enfocada en el comportamiento espec�fico de cada hechizo: da�o al enemigo, efectos especiales...
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
            Debug.Log("Has usado FirefliesBlessing recuperando " + poder + "de man�!");
        }
        else
        {
            Debug.Log("Algo no va bien... no est�s lanzando hechizos!");
        }

        Instantiate(prefabHechizo, transform.position, Quaternion.identity);
        Debug.Log("Has usado " + hechizoName + " causando " + poder + "p de da�o!");
    }

    public void MostrarNombre()
    {
        Debug.Log("Nombre del hechizo: " + hechizoName);
    }
}
