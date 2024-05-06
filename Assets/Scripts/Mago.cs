using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    //Attributes
    public string nombreMago;
    public float Mana;

    private string _name;
    private float _mana;
    private LibroHechizos spellsBook;

    //Methods
    public void LanzarHechizo(string hechizoName)
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            //SpellCasting();
        }
    }

    public void RecargarMana()
    {

    }
}
