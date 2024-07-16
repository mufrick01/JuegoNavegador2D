using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{


    Rigidbody2D _rb;
    [SerializeField] float  _speed;

    float v, h;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(h,v) * _speed;
    }
}
