using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : MonoBehaviour
{
    public string nombreMago;
    public float Mana;
    public float velocidad = 5f;
    public float vida;

    private float speedRotate = 10f;

    public Hechizos[] spellDisponibles;
    public LibroHechizos spellsBook;

    private string _name;
    

    
    void Update()
    {
        MovementPlayer();

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
        else if (Input.GetKeyDown(KeyCode.U))
        {
            LanzarHechizo(3);
            
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            spellsBook.MostrarHechizosAp();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            spellsBook.CerrarLibro();
        }
    }

    void MovementPlayer()
    {
        float moviVertical = Input.GetAxis("Vertical");
        float moviHorizontal = Input.GetAxis("Horizontal");

        Vector3 moverse = new Vector3(moviHorizontal, 0f, moviVertical) * velocidad * Time.deltaTime;
        if(moverse != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(moverse, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, speedRotate * Time.deltaTime);
        }

        transform.Translate(moverse, Space.World);
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

    public void AgregarSpell(Hechizos newHechizo)
    {
        System.Array.Resize(ref spellDisponibles, spellDisponibles.Length + 1);
        spellDisponibles[spellDisponibles.Length - 1] = newHechizo; 

    }


}
