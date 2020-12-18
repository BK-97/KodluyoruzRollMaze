using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuf : MonoBehaviour, ICollectable
{
    public void Collect()
    {
        Use();
    }
    public void Dispose()
    {
        Destroy(gameObject);
    }
    public  void Use()
    {
        FindObjectOfType<Player>().MoveSpeed *= -1;
        Dispose();
    }
}
