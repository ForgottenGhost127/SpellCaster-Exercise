using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hechizos : MonoBehaviour
{
    public string hechizoName;
    public float poder;
    public float manaUsed;
    public float duracion;

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

                GameObject spellInstanciado = Instantiate(spellPrefab, mago.transform.position + mago.transform.forward, mago.transform.rotation);

                HechizoInstanciado hechizoScript = spellInstanciado.AddComponent<HechizoInstanciado>();
                hechizoScript.poder = this.poder;

                Destroy(spellInstanciado, duracion);


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
