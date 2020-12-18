using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : Singleton<CoinManager>
{
    public List<Coin> Coins = new List<Coin>();

    public void AddCoin(Coin coin)
    {
        if (!Coins.Contains(coin))
            Coins.Add(coin);
    } 
    public void RemoveCoin(Coin coin)
    {
        if(Coins.Contains(coin))
            Coins.Remove(coin);

        CheckCoinState();
    }

    private void CheckCoinState()
    {
        if(Coins.Count==0)
        {
            EventManager.onGameOver.Invoke();
            
        }
    }
}
