using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_Move : MonoBehaviour
{
    public float MovementSpeed = 2;
    public float JumpForce = 1;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        var movement2 = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        transform.position += new Vector3(movement2, 0, 0) * Time.deltaTime * MovementSpeed;

        //if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) <0.001f)
        //{
        //    _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        //}
    }
}
