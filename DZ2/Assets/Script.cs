using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CollisionEvent : MonoBehaviour
{
    public int counter = 100;
    public Text count_text;
    // Start is called before the first frame update
    public void Start()
    {
        counter = 100;
        count_text.text = counter.ToString();
    }

    // Update is called once per frame
    public void Update()
    {
        count_text.text = counter.ToString();
    }
    public void OnClick()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OtherObject")
        {
            // уменьшаем счетчик при столкновении с объектом с тегом "OtherObject"
            counter--;
        }
    }
}