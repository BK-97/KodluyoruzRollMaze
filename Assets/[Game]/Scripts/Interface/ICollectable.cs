using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectable
{
    void Collect();
    void Use();
    void Dispose();
}
