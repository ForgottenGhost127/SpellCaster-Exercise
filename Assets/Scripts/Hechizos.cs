using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    //Attributes
    public string hechizoName;
    private float poder;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpellCasting() //Esta funci�n estar enfocada en el comportamiento espec�fico de cada hechizo: da�o al enemigo, efectos especiales...
    {
        print("Has usado " + hechizoName);

    }

    public void MostrarNombre()
    {

    }
}
