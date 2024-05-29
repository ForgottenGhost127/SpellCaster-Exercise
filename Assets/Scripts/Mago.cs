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
    private float _mana;
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

    public void LanzarHechizo(string hechizoName, float duracion) //Esta funci�n maneja la entrada del jugador (presionar una tecla espec�fica) y la creaci�n/lanzamiento del hechizo correspondiente. 
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
                StartCoroutine(spellSelected.SpellCasting(duracion));
            }
            else
            {
                Debug.Log("El hechizo no est� disponible en el libro de hechizos");
            }
        }
        else 
        {
            Debug.Log("No hay hechizos disponibles para castear");
        }
    }

    public void RecargarMana(float cantidad)
    {
        _mana += cantidad;

        Debug.Log("Mana recargado en " + _mana);
    }

    
}
