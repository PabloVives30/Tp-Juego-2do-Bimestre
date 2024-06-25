using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionDeObejetos : MonoBehaviour
{
    public GameObject[] objetos;
    public int CantidadObjetos;
    public int CantidadAparecidos;
    public int MaxSpawn;
    public int MinSpawn;
    public int RandomSpawn;

    // Start is called before the first frame update
    void Start()
    {
        CantidadObjetos = Random.Range(MinSpawn, MaxSpawn + 1);
        CantidadObjetos = CantidadAparecidos;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnearObjetos()
    {
        int SeleccionRandomObject = Random.Range(0, objetos.Length);
        float PositionRandomX = Random.Range(-RandomSpawn, RandomSpawn);
    }
}
