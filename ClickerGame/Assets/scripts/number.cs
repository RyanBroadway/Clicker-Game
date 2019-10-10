using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class number : MonoBehaviour
{
    private int click = 0;
    private bool Spam = false;

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

    IEnumerator Timer()
    {
        click = click + 1;
        yield return new WaitForSeconds(0.05f);
        Spam = false;
    }
    public void Update()
    {
        GetComponent<TextMeshProUGUI>().text = click.ToString();
    }
}
