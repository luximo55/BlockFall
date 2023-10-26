using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public new Rigidbody2D rigidbody {get; private set;}
    public Vector2 direction {get; private set;}
    public float speed = 30f;
    public bool GOI = false;
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            this.direction = Vector2.left;
        } else if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector2.right;
        } else
        {
            this.direction = Vector2.zero;
        }
    }

    public void SpeedBoost()
    {
        speed = 60;
    }

    public void GameOverImmunity()
    {
        GOI = true;
    }

    private void FixedUpdate()
    {
        if (this.direction != Vector2.zero)
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }
}
