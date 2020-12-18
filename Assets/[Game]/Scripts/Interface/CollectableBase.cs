using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CollectableBase : MonoBehaviour, ICollectable
{
    public virtual void Collect()
    {
        Debug.Log(gameObject.name + "Collected");
    }
    public abstract void Use();
    
    public virtual void Dispose()
    {
        Destroy(gameObject);
    }

    
}
