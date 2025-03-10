using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract void DestroyAfterTime();
    public abstract void RunItem();
    

    void Start()
    {
        DestroyAfterTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
