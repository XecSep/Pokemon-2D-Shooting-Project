using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform tr;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();

        Destroy();
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        tr.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.Self);
    }

    private void Destroy()
    {
        Destroy(gameObject, 1.0f);
    }
}
