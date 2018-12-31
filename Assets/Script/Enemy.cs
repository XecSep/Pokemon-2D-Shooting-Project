using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform tr;

    public float moveSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //public void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if (coll.gameObject.tag == "Bullet")
    //    {
    //        Destroy(gameObject);
    //        //GameManager.score += 100;
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            print("Enemy");
            //Destroy(gameObject);
            //GameManager.score += 100;
        }
    }

    private void Move()
    {
        tr.Translate(Vector2.down * moveSpeed * Time.deltaTime, Space.Self);
    }
}
