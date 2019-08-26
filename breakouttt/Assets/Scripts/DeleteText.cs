using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteText : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
        }
    }
}
