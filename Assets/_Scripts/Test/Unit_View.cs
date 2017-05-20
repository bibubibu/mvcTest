using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Unit_View : MonoBehaviour {
    public GameObject pig_prefab;
    public GameObject shooter_prefab;

    void Start()
    {
        GameObject go = Instantiate(shooter_prefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        go.transform.SetParent(transform);
        //所有单位挂在该组件的物体之下
        for (int i = 0; i < Unit_Model.pigs.Count; i++)
        {
            go = Instantiate(pig_prefab, new Vector3(i, i, i), Quaternion.identity) as GameObject;
            go.transform.SetParent(transform);
        }
    }


    public void ShowUnits()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            Transform tr = transform.GetChild(i);
            ShowUnit(tr);
        }
    }
    public void ShowUnit(Transform tr)
    {
        tr.gameObject.SetActive(true);
    }

    public void HideUnits()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform tr = transform.GetChild(i);
            HideUnit(tr);
        }
    }
    public void HideUnit(Transform tr)
    {
        tr.gameObject.SetActive(false);
    }
}
