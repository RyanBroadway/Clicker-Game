using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UGT : MonoBehaviour
{
    int c = 0;
   public void SetTest(string text)
    {
        c = GameObject.Find("Numbers").GetComponent<Number>().UBNL;
        TextMeshProUGUI txt = transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        txt.text = @"Upgrade Number Button
(" + c + " Numbers)";
    }
}
