using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP_Con : MonoBehaviour
{
    public int HP_Point;
    Text HP_Text;

    private void Start()
    {
        HP_Text = GetComponent<Text>();
    }
    void Update()
    {
        HP_Text.text = HP_Point.ToString();
    }
}
