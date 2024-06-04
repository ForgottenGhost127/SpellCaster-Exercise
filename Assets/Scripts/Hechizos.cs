using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    //Attributes
    public string hechizoName;
    public float poder;
    public float manaUsed;

    public GameObject prefabHechizo; //Deber�a estar en el de mago
    public GameObject mago;

    public void Awake()
    {
        mago = GameObject.FindGameObjectWithTag("Player");
    }
    public void MostrarNombre()
    {
        Debug.Log("Nombre del hechizo: " + hechizoName);
    }

    public IEnumerator SpellCasting(Vector3 posicionMago, float duracion) //Esta funci�n estar enfocada en el comportamiento espec�fico de cada hechizo: da�o al enemigo, efectos especiales...
    {
        Mago magoScript = mago.GetComponent<Mago>();

        if(magoScript.Mana >= manaUsed)
        {
            magoScript.RestarMana(manaUsed);

            GameObject spellInstanciado = null;
            if (hechizoName == "DragonBreath")
            {
                spellInstanciado = Instantiate(prefabHechizo, posicionMago, Quaternion.identity); //Los instantiate deben ir en el script de mago.
                Debug.Log("Has lanzado DragonBreath causando " + poder + "de damage!");
                yield return new WaitForSeconds(duracion);
                Debug.Log("DragonBreath ha terminado");
            }
            else if (hechizoName == "IcySpears")
            {
                spellInstanciado = Instantiate(prefabHechizo, posicionMago, Quaternion.identity);
                Debug.Log("Has lanzado IcySpears causando " + poder + "de damage!");
                yield return new WaitForSeconds(duracion);
                Debug.Log("IcySpears ha terminado");
            }
            else if (hechizoName == "FirefliesBlessing")
            {
                spellInstanciado = Instantiate(prefabHechizo, posicionMago, Quaternion.identity);
                mago.GetComponent<Mago>().RecargarMana(poder);
                Debug.Log("Has usado FirefliesBlessing recuperando " + poder + "de man�!");
                yield return new WaitForSeconds(duracion);
                Debug.Log("FirefliesBlessing ha terminado");
            }
            else
            {
                Debug.Log("Algo no va bien... no est�s lanzando hechizos!");
            }

            if (spellInstanciado != null)
            {
                Destroy(spellInstanciado);
            }
        }
        else
        {
            Debug.Log("No tienes suficiente man�.");
        }
        

        
        
    }

   

}
