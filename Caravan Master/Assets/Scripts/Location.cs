using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Location : MonoBehaviour
{
    public Item[] itemList;
    public GameManager gameManager;

    public void SetItemList()
    {
        gameManager.SetItemList(itemList);
    }
}
