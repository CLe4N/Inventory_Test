using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    Inventory inventory;
    public GameObject itemButton;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); // Find gameobject with tag "Player" and access Inventory component
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {"Player"
        if(collision.CompareTag("Player")) // if collided with gameobject with tag "Player"
        {
            for(int i = 0; i < inventory.slot.Length; i++) 
            // loop unless "i" value is more or equal inventory slot Length
                //i is increase by 1 per loop
            {
                if(inventory.isFull[i] == false) // if isFull[i] = false
                {
                    inventory.isFull[i] = true; // isFull[i] = true
                    Instantiate(itemButton, inventory.slot[i].transform); // create prefab itemButton
                    Destroy(gameObject); // destroy this gameobject
                    break; // get out of loop
                }
            }
        }
    }
}
