using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    //Attributes
    public string hechizoName;
    public float poder;
    public float manaUsed;

   
    public GameObject mago;

    public void Awake()
    {
        
    }
    public void MostrarNombre()
    {
        Debug.Log("Nombre del hechizo: " + hechizoName);
    }

    public void SpellCasting() //Esta funci�n estar enfocada en el comportamiento espec�fico de cada hechizo: da�o al enemigo, duraci�n, efectos especiales...
    {
        Mago magoScript = mago.GetComponent<Mago>();

        if(magoScript.Mana >= manaUsed)
        {
            magoScript.RestarMana(manaUsed);

            
        }
        else
        {
            Debug.Log("No tienes suficiente man�.");
        }
        
        
    }

   

}
