using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float enemySpeed;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * enemySpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.score++;
        Destroy(gameObject);

    }
}
 