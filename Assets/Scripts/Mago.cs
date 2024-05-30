using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    //Attributes
    public string nombreMago;
    public float Mana;
    public float velocidad = 5f;
    
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

        

        if (Input.GetKeyDown(KeyCode.I))
        {
            LanzarHechizo("IcySpears", 3f);
        } else if (Input.GetKeyDown(KeyCode.O))
        {
            LanzarHechizo("DragonBreath", 4f);
        } else if (Input.GetKeyDown(KeyCode.P))
        {
            LanzarHechizo("FirefliesBlessing", 2f);
        }

    }

    public void LanzarHechizo(string hechizoName, float duracion) //Esta función maneja la entrada del jugador (presionar una tecla específica) y la creación/lanzamiento del hechizo correspondiente. 
    {
        if (spellDisponibles != null && spellDisponibles.Length > 0)
        {
            Hechizos spellSelected = null;
            foreach (Hechizos spell in spellDisponibles)
            {
                if(spell.hechizoName==hechizoName)
                {
                    spellSelected = spell;
                    break;
                }
            }

            if(spellSelected != null)
            {
                Vector3 posicionMago = transform.position;
                StartCoroutine(spellSelected.SpellCasting(posicionMago, duracion));
            }
            else
            {
                Debug.Log("El hechizo no está disponible en el libro de hechizos");
            }
        }
        else 
        {
            Debug.Log("No hay hechizos disponibles para castear");
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

    
}
