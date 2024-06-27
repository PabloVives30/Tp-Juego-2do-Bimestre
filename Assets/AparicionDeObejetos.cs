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

    void Start()
    {
        CantidadObjetos = Random.Range(minObjects, maxObjects + 1);
        CantidadObjetosEnPantalla = CantidadObjetos;
        InstanciarObjetos();
    }

    void Update()
    {

    }

    public void InstanciarObjetos()
    {
        int i = Random.Range(0, objects.Length);
        float PosicionX = Random.Range(-Limites, Limites);
        float PosicionZ = Random.Range(-Limites, Limites);
        Vector3 randomSpanwpoint = new Vector3(PosicionX, Spawn.position.y, PosicionZ);
        Instantiate(objects[i], randomSpanwpoint, Quaternion.identity);
    }
}