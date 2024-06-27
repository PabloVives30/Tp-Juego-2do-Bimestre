using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparicionDeObejetos : MonoBehaviour
{
    public int CantidadObjetos;
    public int CantidadObjetosEnPantalla;
    public Transform Spawn; 
    public GameObject[] objects;
    public int maxObjects;
    public int minObjects;
    public float Limites;
    public Button responderbtn;
    public InputField inputFieldcantidad;
    int cantidadpantalla;
    int queobjeto;
    public GameObject PanelGanaste;
    public GameObject PanelPerdiste;

    void Start()
    {
        CantidadObjetos = Random.Range(minObjects, maxObjects +1);
        
        queobjeto = Random.Range(0, objects.Length);
        cantidadpantalla = CantidadObjetos;
            InstanciarObjetos();
    }

    void Update()
    {

    }

    public void InstanciarObjetos()
    { 
        float PosicionX = Random.Range(-11.31f, 8.47f);
        float PosicionZ = Random.Range(-5.9f, 17.5f);
        Vector3 randomSpanwpoint = new Vector3(PosicionX, Spawn.position.y, PosicionZ);
        Instantiate(objects[queobjeto], randomSpanwpoint, Quaternion.identity);

        if (cantidadpantalla >= 0)
        {
            cantidadpantalla--;
            Invoke(nameof(InstanciarObjetos), 1f);
        }
    }

    public void botonresponder()
    {
        if (inputFieldcantidad.text == "")
        {
            Debug.Log("Ingrese un número por favor");
        }
        else
        {
            if (int.Parse(inputFieldcantidad.text) == CantidadObjetos)
            {
                PanelGanaste.SetActive(true);
            }
            else
            {
                PanelPerdiste.SetActive(true);
            }
        }
    }

}