using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    enum Target
    {
        Enemy,
        Player
    };

    protected Transform tr;

    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    protected void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    protected void Update()
    {
        Move();
    }

    protected void Move()
    {
        tr.Translate(Vector2.up * moveSpeed * Time.deltaTime, Space.Self);
    }
}
