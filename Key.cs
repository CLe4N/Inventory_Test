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
        Player = GameObject.FindGameObjectWithTag("Player");
        KeySprite = keyItem.GetComponent<SpriteRenderer>();
    }

    public void ShowKey()
    {
        if (KeyIsShow == false)
        {
            Vector2 PlayerPos = new Vector2(Player.transform.position.x, Player.transform.position.y + 1.5f);
            var myKey = Instantiate(keyItem, PlayerPos, Quaternion.identity);
            myKey.transform.SetParent(Player.transform);
            KeyIsShow = true;
        }
        else
        {
            GameObject Key = GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).transform.gameObject;
            Destroy(Key);
            KeyIsShow = false;
        }
    }
}
