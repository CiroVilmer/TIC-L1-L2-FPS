using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncontrarElementoEnArray : MonoBehaviour
{
    public GameObject[] arrayDeMesas;

    private Mesa mesaScript;

    // Start is called before the first frame update
    void Start()
    {
        arrayDeMesas = GameObject.FindGameObjectsWithTag("Mesa");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            desactivarAleatorio();
        }
    }

    void desactivarObjetos()
    {

        for (int i = 0; i < arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].SetActive(false);
        }
    }

    //5 Crear una función que asigne a todos los elementos del array
    //el script mesa. Establecer el valor de la variable destructible aleatoriament.

    void desactivarAleatorio()
    {
        for(int i = 0; i < arrayDeMesas.Length; i++)
        {
            arrayDeMesas[i].AddComponent<Mesa>();

            mesaScript = arrayDeMesas[i].GetComponent<Mesa>();

            int num = Random.Range(0, 2);
            if(num == 0)
            {
                mesaScript.destructible = false;
            }
            if(num == 1)
            {
                mesaScript.destructible = true;
            }
        }

        void jero()
        {
            foreach(GameObject go in arrayDeMesas)
            {
                go.AddComponent<Mesa>();
                go.GetComponent<Mesa>().destructible = Random.Range(0, 2) == 0;


            }
        }
    }
}
