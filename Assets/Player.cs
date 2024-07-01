using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject tama;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tama, transform.position + Vector3.forward * 2, Quaternion.identity);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.playerHitPoint--;
    }
}
