using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject keyItem;
    SpriteRenderer KeySprite;
    GameObject Player;
    public bool KeyIsShow;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player"); // find gameobject with tag "Player"
        KeySprite = keyItem.GetComponent<SpriteRenderer>(); // access SpriteRenderer component
    }

    public void ShowKey()
    {
        if (KeyIsShow == false) // if KeyIsShow = false
        {
            Vector2 PlayerPos = new Vector2(Player.transform.position.x, Player.transform.position.y + 1.5f);
            // get player position
            var myKey = Instantiate(keyItem, PlayerPos, Quaternion.identity);
            //create prefab keyItem
            myKey.transform.SetParent(Player.transform);
            // assige this gameobject to player as child
            KeyIsShow = true; // KeyIsShow = true
        }
        else
        {
            GameObject Key = GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).transform.gameObject;
            // get child(0) of gameobject with tag "Player"
            Destroy(Key); // destroy key
            KeyIsShow = false; // KeyIsShow = false
        }
    }
}
