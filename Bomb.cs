using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public GameObject Effect;
    Transform Player;
    HP_Con hp;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform; // find gameobject with tag "Player" and access transform
        hp = GameObject.Find("HPtext").GetComponent<HP_Con>(); // find "HPtext" and access HP_Con component
    }

    // Update is called once per frame
    public void BombEffect()
    {
        if (Effect != null) // if effect is not empty
        {
            hp.HP_Point -= 1; // HP_Point is decrease by 1
            Instantiate(Effect, Player.position, Quaternion.identity); // create prefab Effect 
            Destroy(this.gameObject); // destroy this game object
        }
    }

    public void DestroyThis()
    {
        Destroy(this.gameObject); // detroy this gameobject
    }
}
