using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potion : MonoBehaviour
{
    HP_Con hp;
    void Start()
    {
        hp = GameObject.Find("HPtext").GetComponent<HP_Con>(); // find gameobject "HPtext" and access HP_Con component
    }

    public void Heal()
    {
        hp.HP_Point += 1; // HP_Point increase by 1
        Destroy(this.gameObject); // destroy this gameobject
    }
}
