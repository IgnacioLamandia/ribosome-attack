using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float difference = 5;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
        Vector3 dir = pos - transform.position; 
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,angle + difference);
    }
}
