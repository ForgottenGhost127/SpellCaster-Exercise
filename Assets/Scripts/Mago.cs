using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    //Attributes
    public string nombreMago;
    public float Mana;
    public float velocidad = 5f;
    public float vida;

    public Hechizos[] spellDisponibles;

    private string _name;
    private LibroHechizos spellsBook;

    //Methods
    void Update()
    {
        float moviVertical = Input.GetAxis("Vertical");
        float moviHorizontal = Input.GetAxis("Horizontal");

        Vector3 moverse = new Vector3(moviHorizontal, 0f, moviVertical) * velocidad * Time.deltaTime;
        transform.Translate(moverse);

        
        if (Input.GetKeyDown(KeyCode.O))
        {
            LanzarHechizo(0);
            print("Se ha lanzado 0");
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            LanzarHechizo(1);
            print("Se ha lanzado 1");
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            LanzarHechizo(2);
            RecargarMana(45);
            print("Se ha lanzado 2");
        }
        //else if (Input.GetKeyDown(KeyCode.U))
        //{
        //    LanzarHechizo(3);
        //    print("Se ha lanzado 3");
        //}

        if (Input.GetKeyDown(KeyCode.Q))
        {
            spellsBook.MostrarHechizosAp();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            spellsBook.CerrarLibro();
        }
    }

    void LanzarHechizo(int index)
    {
        if (index < spellDisponibles.Length)
        {
            spellDisponibles[index].SpellCasting();
        }
        else
        {
            Debug.Log("El índice del hechizo está fuera de rango.");
        }
    }

    public void RestarMana(float cantidad)
    {
        Mana -= cantidad;
    }

    public void RecargarMana(float cantidad)
    {
        Mana += cantidad;
        Debug.Log("Mana recargado en " + Mana);
    }

    //public void AgregarSpell(Hechizos newHechizo)
    //{
    //    //Se puede cambiar a una Lista pero no quiero, preguntar a Anxo.

    //}


}
