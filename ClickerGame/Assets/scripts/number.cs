using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class number : MonoBehaviour
{
    int click = 0;

    public void Start()
    {

    }

    public void Onclick()
    {
        click = click + 1;
        
    }

    // Update is called once per frame
    public void Update()
    {
        GetComponent<TextMeshProUGUI>().text = click.ToString();
    }
}
