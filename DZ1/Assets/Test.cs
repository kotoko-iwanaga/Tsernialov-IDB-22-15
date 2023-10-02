using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject SPHERE;
    public int switcher = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if(switcher == 0)
        {
            SPHERE.transform.localScale = new Vector3(0, 0, 0);
            switcher = 1;
        }
        else
        {
            SPHERE.transform.localScale = new Vector3(30, 30, 30);
            switcher = 0;
        }
    }
}
