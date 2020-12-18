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
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

}
 