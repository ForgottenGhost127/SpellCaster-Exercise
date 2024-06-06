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

        //Aquí hemos de referir a los Keycode que se usaran para lanzar cada hechizo y controlar el libro (abrir y cerrar)

    }

    public void LanzarHechizo(string hechizoName, float duracion) //Esta función maneja la entrada del jugador (presionar una tecla específica) y la creación/lanzamiento del hechizo correspondiente. 
    {
        //Instanciar los tres hechizos para que el mago los pueda llamar incluso si los prefabs no están en el menu Hierarchy.
        
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
