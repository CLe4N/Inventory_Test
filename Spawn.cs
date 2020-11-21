using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform; // find gameobject with tag "Player"
    }

    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(Player.position.x, Player.position.y + 2); // get player position
        Instantiate(item, playerPos, Quaternion.identity); // create prefab item on player position
    }
}
