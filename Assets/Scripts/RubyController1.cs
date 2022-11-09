using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController1 : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody2D.position;
        position.x = position.x + 14.0f * horizontal * Time.deltaTime;
        position.y = position.y + 14.0f * vertical * Time.deltaTime;

        rigidbody2D.MovePosition(position);
    }
}

