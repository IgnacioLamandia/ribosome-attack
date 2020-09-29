using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARNController : MonoBehaviour
{
    public GameObject ARN;
    public GameObject pointL;
    public GameObject pointR;
    private float limitL;
    private float limitR;
    float FireRate = 3.0f;
    float NextFire;
    // Start is called before the first frame update
    void Start()
    {
        NextFire = FireRate;
        limitL = pointL.transform.position.x;
        limitR = pointR.transform.position.x;
    }



    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextFire)
        {
            NextFire += FireRate;
            float randomX = Random.Range(limitL, limitR);
            Instantiate(ARN, new Vector3(randomX, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
}
