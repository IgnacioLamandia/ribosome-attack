using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ribosome : MonoBehaviour
{
    private GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        StartCoroutine(Expire());
    }

    IEnumerator Expire()
    {
        yield return new WaitForSeconds(4);
        controller.ribosomeLosts += 1;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
