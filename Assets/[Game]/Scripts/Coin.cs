using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : CollectableBase
{
    private void Awake()
    {
       CoinManager.Instance.AddCoin(this);
    }
    private void OnDestroy()
    {
        CoinManager.Instance.RemoveCoin(this);
    }

    public override void Collect()
    {
        base.Collect();
        Use();
    }
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
    public override void Use()
    {
        EventManager.onCoinPickUp.Invoke(1);
        Dispose();
    }
}
 