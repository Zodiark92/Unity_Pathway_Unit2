using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    private float boundZ = 35f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > boundZ || transform.position.z < -boundZ)
        {
            Destroy(gameObject);
        }
    }
}
