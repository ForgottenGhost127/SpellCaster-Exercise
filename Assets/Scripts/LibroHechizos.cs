using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LibroHechizos : MonoBehaviour
{
    public List<string> hechizosLearned;

    private bool libroAbi = false;

    public Canvas libroCan;
    public TextMeshProUGUI initialText;
    public TextMeshProUGUI newSpellText;

    void Start()
    {
        libroCan = GetComponentInChildren<Canvas>();

        if (libroCan != null)
        {
            Debug.Log("Canvas encontrado: " + libroCan.name);
            libroCan.gameObject.SetActive(false);
        }
        else
        {
            Debug.LogError("No se encontró un Canvas hijo en SpellBook.");
        }

        if (newSpellText != null)
        {
            newSpellText.gameObject.SetActive(false);
        }

    }

    public void AprenderHechizo(string hechizoName)
    {
       if(!hechizosLearned.Contains(hechizoName))
        {
            hechizosLearned.Add(hechizoName);
            print("Has aprendido a usar: " + hechizoName);
            MostrarDescHechizo(hechizoName);
        }
       else
        {
            print("Ya conoces el hechizo: " + hechizoName);
        }
    }
    public void MostrarHechizosAp()
    {
       if(!libroAbi && libroCan != null)
        {
            libroAbi = true;
            libroCan.gameObject.SetActive(true);
            print("Has abierto el libro");
        }
        
    }

    public void CerrarLibro()
    {
        if(libroAbi && libroCan != null)
        {
            libroAbi = false;
            libroCan.gameObject.SetActive(false);
            print("Has cerrado el libro");
        }
    }

    public void MostrarDescHechizo(string hechizoName)
    {
        if(newSpellText != null)
        {
            newSpellText.gameObject.SetActive(false);
        }

        if (hechizoName == "MagnisBlast")
        {
            if (newSpellText != null)
            {
                newSpellText.gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.LogWarning("No hay descripción para el hechizo: " + hechizoName);
        }
    }


}
