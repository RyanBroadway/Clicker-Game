using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UGT : MonoBehaviour
{
    double c = 0;
    int h = 0;
   public void SetTest(string text)
    {
        c = GameObject.Find("Numbers_upgrade").GetComponent<Number>().UBNL;
        h = Convert.ToInt32()
        TextMeshProUGUI txt = transform.Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
        txt.text = "Upgrade Number Button ( " + c + " Numbers)";
    }
}
