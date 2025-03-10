using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class JumpItems : MonoBehaviour
{
    Vector3 pos; 

    float delta = 0.5f; 

    float Item_speed = 3f; 

    void Start()
    {
        pos = this.transform.position;
    }

    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * Item_speed);
        transform.position = v;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
    
}