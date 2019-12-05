using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button_pop : MonoBehaviour
{
    string c = "";
    int x = 0;
    int y = 0;
    GameObject canvas;
    void Start()
    {
        Destroy(gameObject, 3);

    }
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 100);
        c = (GameObject.Find("Numbers").GetComponent<Number>().amount).ToString();
        c = ("+" + c);
        GetComponent<TextMeshProUGUI>().text = c;
    }
    public void OnClick()
    {
        x = Random.Range(-140, 140);
        y = Random.Range(-140, 140);
        canvas = GameObject.Find("Canvas");
        GameObject Text = Instantiate(gameObject);
        Text.transform.parent = canvas.transform;
        Text.transform.position = new Vector2(490 + x, 384 + y);
    }
}
