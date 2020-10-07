using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARNController : MonoBehaviour
{
    public GameObject ARN;
    public GameObject pointL;
    public GameObject pointR;
    private GameController controller;
    private float limitL;
    private float limitR;
    public float FireRate;
    float NextFire;
    // Start is called before the first frame update
    void Start()
    {

        FireRate = 3f;
        NextFire = Time.time + FireRate;
        limitL = pointL.transform.position.x;
        limitR = pointR.transform.position.x;
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

    }



    // Update is called once per frame
    void Update()
    {
        if(controller.ribosomeLosts > 10)
        {
            FireRate = 2f;
        }
        else if(controller.ribosomeLosts > 5)
        {
            FireRate = 2.5f;
        }
        if (Time.time >= NextFire)
        {
            NextFire = Time.time + FireRate;
            float randomX = Random.Range(limitL, limitR);
            Instantiate(ARN, new Vector3(randomX, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
