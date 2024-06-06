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
        //sería un if en referencia a: oncollisionEnter con el objeto en referencia al hechizo que va a aprender, es decir, si colisiona el player con este objeto, el hechizo se añade al libro.
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
