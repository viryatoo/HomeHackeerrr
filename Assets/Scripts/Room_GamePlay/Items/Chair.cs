﻿using RoomGP.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Реалиция предмета стула
/// чтобы понять как работает,смотри класс Bed.cs
/// </summary>
public class Chair : Item,IBaseItem
{
    public void Choose()
    {
        Debug.Log("А на такой стул даже бомжи не сядят");
    }

    public void LevelUP()
    {
        Debug.Log("Покупаем стулл");
        if(ShopManager.Money>= levels[level+1].price)
        {
            ShopManager.Money -= levels[level + 1].price;
            level++;
            ChangeModel(level);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        item = this;
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
