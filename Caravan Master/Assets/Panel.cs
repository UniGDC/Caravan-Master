using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public Text objectName;
    public Text objectPrice;

    public void SetCell(string _name, int _price)
    {
        objectName.text = _name;
        objectPrice.text = "$"+_price.ToString();
    }
}
