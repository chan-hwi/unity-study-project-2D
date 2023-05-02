using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float vInput = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(hInput, vInput).normalized;
        Vector2 newPosition = new Vector2(transform.position.x, transform.position.y) + dir * speed * Time.deltaTime;
        rigidbody2D.MovePosition(newPosition);
    }
}
