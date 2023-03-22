using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class GetParentName : MonoBehaviour
{
    public GameObject parent;

    private void Awake()
    {
        var tmp = GetComponent<TMP_Text>();
        if (tmp != null && parent != null)
        {
            tmp.text = parent.name;
        }
    }
}
