using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private GameObject foodPrefab;

    [SerializeField]
    private Transform spawnPos;

    private float xRange = 14f;

    private float horizontalInput;

    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        } else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        spawnApple();
        
    }

    private void spawnApple()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(foodPrefab, spawnPos.position, foodPrefab.transform.rotation);
        }
    }
}
