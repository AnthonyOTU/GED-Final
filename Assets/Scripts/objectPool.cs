using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPool : MonoBehaviour
{
    public static objectPool SharedInstance;
    public GameObject duck;
    public int amount;
    public List<GameObject> pooledDucks;
    

    void Awake() {
        SharedInstance = this;
    }

    // Start is called before the first frame update
     void Start()
    {
        pooledDucks = new List<GameObject>(); 
        GameObject temporaryObject;


        for (int i = 0; i < amount; i++){
            temporaryObject = Instantiate(duck);
            temporaryObject.SetActive(false);
            pooledDucks.Add(temporaryObject);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < amount; i++)
        {
            if (!pooledDucks[i].activeInHierarchy)
            {
                return pooledDucks[i];
            }
        }
        return null;
    }


}
