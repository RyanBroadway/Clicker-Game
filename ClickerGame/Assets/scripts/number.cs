﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class Number : MonoBehaviour
{
    private int Numbers = 0;
    private bool Spam = false;
    public int amount = 1;
    private double cost = 0;
    public int UBNL = 50;

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
        if (Numbers >= UBNL)
        {
            amount += 1;
            Numbers -= UBNL;
            cost = 50 * Math.Pow(1.2, amount - 1);
            UBNL = Convert.ToInt32(cost);
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
