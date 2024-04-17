using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Singleton para el inventario del jugador
    public static PlayerInventory Instance;

    // Lista de objetos en el inventario
    public List<GameObject> inventory = new List<GameObject>();

    // Separación entre objetos en el inventario
    public float separation = 0.5f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Agregar un objeto al inventario
    public void AddToInventory(GameObject item)
    {
        inventory.Add(item);
        Debug.Log("¡Prefab recogido!");

        // Colocar el objeto en la posición correcta en el inventario
        ArrangeInventory();
    }

    // Colocar el objeto en la posición correcta en el inventario
    void ArrangeInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Vector3 newPosition = transform.position + Vector3.up * (i + 1) * separation;
            inventory[i].transform.position = newPosition;
        }
    }

    // Actualizar las posiciones de los objetos en el inventario para que sigan al jugador
    void LateUpdate()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Vector3 newPosition = transform.position + Vector3.up * (i + 1) * separation;
            inventory[i].transform.position = newPosition;
        }
    }
      public bool HasItem(GameObject item)
    {
        return inventory.Contains(item);
    }
}

