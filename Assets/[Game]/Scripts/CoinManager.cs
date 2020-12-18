using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : Singleton<CoinManager>
{
    public List<Coin> Coins = new List<Coin>();

    public int Coin;

    private void OnEnable()
    {
        EventManager.onCoinPickUp.AddListener(UpdateCoin);
    }
    private void OnDisable()
    {
        EventManager.onCoinPickUp.RemoveListener(UpdateCoin);
    }
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

    private void UpdateCoin(int amount)
    {
        Coin += amount;
    }
    private void CheckCoinState()
    {
        if(Coins.Count==0)
        {
            EventManager.onGameOver.Invoke();
            
        }
    }
}
