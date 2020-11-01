using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour
{
    HP_Con hp;
    void Start()
    {
        hp = GameObject.Find("HPtext").GetComponent<HP_Con>();
    }

    public void Heal()
    {
        hp.HP_Point += 1;
        Destroy(this.gameObject);
    }
}
