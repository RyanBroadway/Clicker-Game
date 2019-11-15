using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int Numbers = 0;
    private bool Spam = false;
    private int amount = 1;
    public double UBNL = 0;

    public void Start()
    {

    }

    public void Onclick()
    {
        if (Spam == false)
        {
            Spam = true;
            StartCoroutine(Timer());
        }
    }
    public void OnclickU()
    {
        if (Numbers >= 50)
        {
            amount += 1;
            Numbers -= 50;
            UBNL = (50 * 1.5^(amount - 1));
        }
    }
    IEnumerator Timer()
    {
        Numbers = Numbers + amount;
        yield return new WaitForSeconds(0.05f);
        Spam = false;
    }
    public void Update()
    {
        GetComponent<TextMeshProUGUI>().text = Numbers.ToString();
    }
}
