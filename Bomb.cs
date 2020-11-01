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
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        hp = GameObject.Find("HPtext").GetComponent<HP_Con>();
    }

    // Update is called once per frame
    public void BombEffect()
    {
        if (Effect != null)
        {
            hp.HP_Point -= 1;
            Instantiate(Effect, Player.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    public void DestroyThis()
    {
        Destroy(this.gameObject);
    }
}
