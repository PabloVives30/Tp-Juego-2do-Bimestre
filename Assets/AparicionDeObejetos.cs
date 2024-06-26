using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AparicionDeObejetos : MonoBehaviour
{
    public Transform Spawn; // Actual number of objects on screen
    public GameObject[] objects; // Array to store the objects

    void Start()
    {
        InstanciarObjetos();
    }

    void Update()
    {

    }

    public void InstanciarObjetos()
    {
        int i = Random.Range(0, objects.Length);
        Vector3 randomSpanwpoint = new Vector3(Random.Range(-5,6), 5, Random.Range(-5,6));
        Instantiate(objects[i], randomSpanwpoint, Quaternion.identity);
    }
}