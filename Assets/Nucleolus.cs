using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nucleolus : MonoBehaviour
{
    public GameObject ribosome;
    public Image cooldownIndicator;
    public float speed = 1;
    public float DelayBetweenThrows = 1;
    public Animator animator;

    float lastThrowDate;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Shoot()
    {
        Vector3 shootDirection;
        shootDirection = Input.mousePosition;
        shootDirection.z = 0.0f;
        shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
        shootDirection = shootDirection - transform.position;
        //...instantiating the rocket
        GameObject bulletInstance = Instantiate(ribosome, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        bulletInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(shootDirection.x * speed, shootDirection.y * speed);
    }
    // Update is called once per frame
    void Update()
    {
        if((Time.time - lastThrowDate > DelayBetweenThrows))
        {
            cooldownIndicator.color = Color.green;
        }
        else
        {
            cooldownIndicator.color = Color.red;
        }
        if (Input.GetMouseButtonDown(0) && (Time.time - lastThrowDate > DelayBetweenThrows)) {
            animator.SetTrigger("IsShooting");
            Shoot();
            lastThrowDate = Time.time;
        }
    }
}
