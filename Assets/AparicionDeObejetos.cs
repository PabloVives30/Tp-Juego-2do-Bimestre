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
    public Transform Spawner;
    public int RandomSpawn-40;

    // Start is called before the first frame update
    void Start()
    {
        CantidadObjetos = Random.Range(MinSpawn, MaxSpawn + 1);
        CantidadObjetos = CantidadAparecidos;
        SpawnearObjetos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnearObjetos()
    {
        CantidadAparecidos--;
        int SeleccionRandomObject = Random.Range(0, objetos.Length);
        float PositionRandomX = Random.Range(-RandomSpawn, RandomSpawn);
        float PositionRandomZ = Random.Range(-RandomSpawn, RandomSpawn);

        Vector3 posicion = new Vector3(PositionRandomX, Spawner.position.y, PositionRandomZ);
        Instantiate(objetos[SeleccionRandomObject], posicion, Quaternion.identity);
    }
}
