using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPoint : MonoBehaviour
{
    private bool isSelected = false;
    public int id = 0;
    public void SetData(int id)
    {
        this.id = id;
        isSelected = false;
        GetComponent<CircleCollider2D>().enabled = true;
        foreach (Transform tr in transform)
        {
            tr.gameObject.SetActive(false);
        }
        transform.GetChild(id).gameObject.SetActive(true);
        SetUnCollected();
    }

    public void SetCollected()
    {
        if(isSelected) return;
        isSelected = true;
        transform.GetChild(transform.childCount-1).gameObject.SetActive(true);
        GetComponent<CircleCollider2D>().enabled = false;
    }
    public void SetUnCollected()
    {
        isSelected = false;
        transform.GetChild(transform.childCount-1).gameObject.SetActive(false);
        GetComponent<CircleCollider2D>().enabled = true;
    }
}
