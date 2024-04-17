using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class Slide : MonoBehaviour
{
     public Vector3 Pos;
    public GameObject[] prefabs;
    public float spawnInterval = 20f;

    private int currentPrefabIndex = 0;

    void Start()
    {
        StartCoroutine(SpawnPrefabs());
    }

    IEnumerator SpawnPrefabs()
    {
        // Cargar la lista de prefabs desde la carpeta
        LoadPrefabsFromFolder();

        while (true)
        {
            // Spawnear el prefab actual
            Instantiate(prefabs[currentPrefabIndex], Pos, Quaternion.identity);

            // Avanzar al siguiente prefab en la lista
            currentPrefabIndex = (currentPrefabIndex + 1) % prefabs.Length;

            // Esperar el intervalo de tiempo antes de spawnear el siguiente prefab
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void LoadPrefabsFromFolder()
    {
        // Ruta de la carpeta de prefabs
        string folderPath = "Prefab/Proyectiles";

        // Obtener todos los prefabs dentro de la carpeta de prefabs
        GameObject[] prefabsArray = Resources.LoadAll<GameObject>(folderPath);

        // Asignar los prefabs encontrados al arreglo de prefabs
        prefabs = prefabsArray;
    }
}