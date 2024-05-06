using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibroHechizos : MonoBehaviour
{
    //Attributes
    public List<string> hechizosLearned;

    //Methods
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            MostrarHechizosAp();
        }
    }
    public void AprenderHechizo(string hechizoName)
    {

    }
    public void MostrarHechizosAp()
    {
        print("Has abierto el libro");
    }
}
