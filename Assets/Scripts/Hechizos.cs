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

    public void MostrarNombre()
    {
        Debug.Log("Nombre del hechizo: " + hechizoName);
    }

    public IEnumerator SpellCasting(float duracion) //Esta funci�n estar enfocada en el comportamiento espec�fico de cada hechizo: da�o al enemigo, efectos especiales...
    {
        GameObject spellInstanciado = null;
        if (hechizoName== "DragonBreath")
        {
            spellInstanciado = Instantiate(prefabHechizo, transform.position, Quaternion.identity);
            Debug.Log("Has lanzado DragonBreath causando " + poder + "de damage!");
            yield return new WaitForSeconds(duracion);
            Debug.Log("DragonBreath ha terminado");
        }
        else if (hechizoName == "IcySpears")
        {
            spellInstanciado = Instantiate(prefabHechizo, transform.position, Quaternion.identity);
            Debug.Log("Has lanzado IcySpears causando " + poder + "de damage!");
            yield return new WaitForSeconds(duracion);
            Debug.Log("IcySpears ha terminado");
        }
        else if (hechizoName == "FirefliesBlessing")
        {
            spellInstanciado = Instantiate(prefabHechizo, transform.position, Quaternion.identity);
            mago.GetComponent<Mago>().RecargarMana(poder);
            Debug.Log("Has usado FirefliesBlessing recuperando " + poder + "de man�!");
            yield return new WaitForSeconds(duracion);
            Debug.Log("FirefliesBlessing ha terminado");
        }
        else
        {
            Debug.Log("Algo no va bien... no est�s lanzando hechizos!");
        }

        if(spellInstanciado != null)
        {
            Destroy(spellInstanciado);
        }

        
        
    }

   

}
