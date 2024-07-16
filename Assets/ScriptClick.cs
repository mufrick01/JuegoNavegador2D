using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptClick : MonoBehaviour
{

    SpriteRenderer _sr;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (_sr.color == Color.red)
            {
                _sr.color = Color.white;
            }
            else
            {
                _sr.color = Color.red;
            }
        }
    }
}
