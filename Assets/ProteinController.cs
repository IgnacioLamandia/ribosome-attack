using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProteinController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyItself());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DestroyItself()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
