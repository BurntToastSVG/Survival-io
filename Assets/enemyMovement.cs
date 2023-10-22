using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    private float speed;
    private Rigidbody2D gravity;
    private float hp;
    private Transform playerTransform;

    private void Start()
    {
        speed = 1;
        gravity = GetComponent<Rigidbody2D>();
        hp = 100f;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }

    public void TakeDamage(float Damage)
    {
        hp -= Damage;

        if(hp < 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            print("enemy got shot");
        }
    }






}

