using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class EventManager
{
    public static CoinEvent onCoinPickUp = new CoinEvent();
    public static UnityEvent onGameOver = new UnityEvent();
}

public class CoinEvent: UnityEvent<int> { }
   
