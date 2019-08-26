using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GM.instance.Setup();
            Destroy(gameObject);
        }
    }
}
