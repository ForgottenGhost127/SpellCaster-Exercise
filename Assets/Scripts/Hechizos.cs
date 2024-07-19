using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    //Attributes
    public string hechizoName;
    public float poder;
    public float manaUsed;
    //public float duracion = 3f;

    public GameObject spellPrefab;
    
    public void SpellCasting() 
    {
        GameObject mago;
        mago = GameObject.FindGameObjectWithTag("Player");
        Mago magoScript = mago.GetComponent<Mago>();
        

        if (mago != null)
        {
            if (magoScript.Mana >= manaUsed)
            {
                magoScript.RestarMana(manaUsed);
                print(hechizoName + " lanzado con poder " + poder);

                Instantiate(spellPrefab, mago.transform.position + mago.transform.forward, mago.transform.rotation);
                //yield return new WaitForSeconds(duracion);


            }
            else
            {
                Debug.Log("No tienes suficiente maná.");
            }
        }
        else
        {
            Debug.LogError("El GameObject 'Mago' no está asignado");
        }
        
        
        
    }


}
