using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public static class EventManager
{
    public static UnityEvent onCoinPickUp = new UnityEvent();
    public static UnityEvent onGameOver = new UnityEvent();
}
   
