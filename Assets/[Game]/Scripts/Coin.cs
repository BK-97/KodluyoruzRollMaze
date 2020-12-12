using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private void Start()
    {
       CoinManager.Instance.AddCoin(this);
    }
    private void OnDestroy()
    {
        CoinManager.Instance.RemoveCoin(this);
    }
    public void PickUpCoin(int point)
    {
        EventManager.onCoinPickUp.Invoke();
        Destroy(gameObject);
    }

}
 