using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButPos : MonoBehaviour
{
    public Vector2 pos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
    }
}
