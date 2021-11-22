using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private InventoryTest inventoryTest;
    public int i;

    private void Start()
    {
        inventoryTest = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryTest>();
    }

    private void Update()
    {
        if(transform.childCount <= 0)
        {
            inventoryTest.isFull[i] = false;
        }
    }
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
