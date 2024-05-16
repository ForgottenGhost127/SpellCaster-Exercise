using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroHechizos : MonoBehaviour
{
    //Attributes
    public List<string> hechizosLearned;

    private bool libroAbi = false;

    //Methods
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            MostrarHechizosAp();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            CerrarLibro();
        }
    }
    public void AprenderHechizo(string hechizoName)
    {

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
