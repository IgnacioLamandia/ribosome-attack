using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARN : MonoBehaviour
{
    private GameController gameController;
    public GameObject protein;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Expire());
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Expire()
    {
        yield return new WaitForSeconds(4);
        gameController.addARNLost();
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ribosome")
        {
            gameController.addProtein();
            Instantiate(protein, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
