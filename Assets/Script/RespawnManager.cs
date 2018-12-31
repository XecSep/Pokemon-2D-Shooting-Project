using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public Transform[] points;
    public GameObject enemyPrefab;

    public float createTime = 2.0f;
    public int maxEnemy = 13;

    public bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.Find("SpawnPoint").GetComponentsInChildren<Transform>();

        if(points.Length>0)
        {
            StartCoroutine(this.CreateEnemy());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreateEnemy()
    {
        while(!isGameOver)
        {
            int enemyCount = (int)GameObject.FindGameObjectsWithTag("Enemy").Length;

            if(enemyCount<maxEnemy)
            {
                yield return new WaitForSeconds(createTime);

                int idx = Random.Range(1, points.Length);

                Instantiate(enemyPrefab, points[idx].position, points[idx].rotation);
            }
            else
            {
                yield return null;
            }
        } 
    }
}
