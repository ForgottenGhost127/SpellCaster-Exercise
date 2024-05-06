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

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(moverse);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(moverse);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(moverse);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(moverse);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            //LanzarHechizo();
        }
    }
    public void LanzarHechizo(string hechizoName) //Esta función maneja la entrada del jugador (presionar una tecla específica) y la creación/lanzamiento del hechizo correspondiente. 
    {
        //if (spellDisponibles.Length>0)
        //{
        //    Hechizos spellSelected = null;
        //    foreach (Hechizos hechizo in spellDisponibles)
        //    {
        //        if(hechizo.hechizoName == hechizoName)
        //        {
        //            spellSelected = hechizo;
        //            break;
        //        }
        //    }
        //}
    }

    public void RecargarMana()
    {

    }
}
