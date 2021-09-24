using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int[] hotbar;
    public int selected;

    void Equip(int slot)
    {
        int item = hotbar[slot];
    }

    void Start()
    {
        hotbar = new int[4];
        selected = 1;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selected = 1;
            Equip(1);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            selected = 2;
            Equip(2);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            selected = 3;
             Equip(3);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            selected = 4;
            Equip(4);
        }
    }
}