using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private InventoryTest inventoryTest;
    public GameObject itemButton;
    private void Start()
    {
        inventoryTest = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryTest>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i =0; i < inventoryTest.slots.Length; i++)
            {
                if (inventoryTest.isFull[i] == false )
                {
                    //ของเข้ากระเป๋า
                    inventoryTest.isFull[i] = true;
                    Instantiate(itemButton, inventoryTest.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
