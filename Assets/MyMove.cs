using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMove : MonoBehaviour
{
    public float force;

    private Rigidbody2D body;

    private float horizontal;
    private float vertical;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Debug.Log("水平轴按键输入：" + horizontal);
        Debug.Log("垂直轴按键输入：" + vertical);
        movement = new Vector2(horizontal, vertical);
    }

    private void FixedUpdate()
    {
        body.AddForce(movement * force);
    }
}
