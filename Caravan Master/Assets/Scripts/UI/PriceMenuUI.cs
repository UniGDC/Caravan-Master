using UnityEngine.UI;
using UnityEngine;

public class PriceMenuUI : MonoBehaviour
{
    public GameObject cellPrefab;
    public GameObject parentObject;

    public int bufferAmount;

    public void GenerateCells(Item[] itemlist)
    {
        foreach (Transform child in parentObject.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        Panel panel = cellPrefab.GetComponent<Panel>();
        foreach (Item item in itemlist)
        {
            GameObject cell = Instantiate(cellPrefab, parentObject.transform);
            cell.GetComponent<Panel>().SetCell(item.name, item.price);
        }

    }



}
