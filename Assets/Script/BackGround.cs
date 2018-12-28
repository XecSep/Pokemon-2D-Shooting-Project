using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 1.5f;

    Material mt;

    // Start is called before the first frame update
    void Start()
    {
        mt = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float newOffsetY = mt.mainTextureOffset.y + scrollSpeed * Time.deltaTime;

        Vector2 newOffset = new Vector2(0, newOffsetY);

        mt.mainTextureOffset = newOffset;
    }
}
