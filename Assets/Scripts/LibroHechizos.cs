using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroHechizos : MonoBehaviour
{
    //Attributes
    public List<string> hechizosLearned;

    private bool libroAbi = false;

    //Methods
    
    public void AprenderHechizo(string hechizoName)
    {
       if(!hechizosLearned.Contains(hechizoName))
        {
            hechizosLearned.Add(hechizoName);
            print("Has aprendido a usar: " + hechizoName);
        }
       else
        {
            print("Ya conoces el hechizo: " + hechizoName);
        }
    }
    public void MostrarHechizosAp()
    {
       if(!libroAbi)
        {
            libroAbi = true;
            print("Has abierto el libro");
        }
        
    }

    public void CerrarLibro()
    {
        if(libroAbi)
        {
            libroAbi = false;
            print("Has cerrado el libro");
        }
    }

   
}
