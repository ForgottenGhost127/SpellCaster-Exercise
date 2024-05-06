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

    public void SpellCasting() //Esta función estar enfocada en el comportamiento específico de cada hechizo: daño al enemigo, efectos especiales...
    {
        print("Has usado " + hechizoName);

    }

    public void MostrarNombre()
    {

    }
}
