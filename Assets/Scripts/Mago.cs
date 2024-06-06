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

        //Aqu� hemos de referir a los Keycode que se usaran para lanzar cada hechizo y controlar el libro (abrir y cerrar)

    }

    public void LanzarHechizo(string hechizoName, float duracion) //Esta funci�n maneja la entrada del jugador (presionar una tecla espec�fica) y la creaci�n/lanzamiento del hechizo correspondiente. 
    {
        //Instanciar los tres hechizos para que el mago los pueda llamar incluso si los prefabs no est�n en el menu Hierarchy.
        
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
