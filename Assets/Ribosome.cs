using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribosome : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Expire());
    }

    IEnumerator Expire()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
