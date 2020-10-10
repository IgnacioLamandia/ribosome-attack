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
    private Animator animator;

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

        float rotationZ = Mathf.Atan2(shootDirection.x, shootDirection.y) * Mathf.Rad2Deg;
        //...instantiating the rocket
        GameObject bulletInstance = Instantiate(ribosome, transform.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        bulletInstance.transform.rotation = Quaternion.Euler(0, 0, rotationZ);
        Rigidbody2D bulletRigi = bulletInstance.GetComponent<Rigidbody2D>();

        float distance = shootDirection.magnitude;
        Vector2 direction = shootDirection / distance;
        direction.Normalize();
        bulletRigi.AddForce(direction * speed, ForceMode2D.Impulse);
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
