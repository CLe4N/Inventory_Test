using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    Inventory inventory;
    public int i;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); // find gameobject with tag "Player"
    }

    private void Update()
    {
        if(transform.childCount <= 0) // if child number is less or equal 0
        {
            inventory.isFull[i] = false; // isFull[i] = false
        }
    }

    public void dropItem()
    {
        foreach(Transform child in transform) // loop by child number
        {
            child.GetComponent<Spawn>().SpawnDroppedItem(); // access Spawn component and call method SpawnDroppedItem
            GameObject.Destroy(child.gameObject) ; // destroy child object
        }
    }
}
