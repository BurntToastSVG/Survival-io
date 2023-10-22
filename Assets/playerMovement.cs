using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D gravity;
    private Vector2 direction;


    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        gravity.MovePosition(gravity.position + direction * speed * Time.deltaTime);

        print(direction);
    }



}
