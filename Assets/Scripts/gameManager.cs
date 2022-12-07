using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject duck = objectPool.SharedInstance.GetPooledObject();
        if (duck != null)
        {
            duck.transform.position = spawnPoint.transform.position;
            duck.SetActive(true);
        }
    }
}
