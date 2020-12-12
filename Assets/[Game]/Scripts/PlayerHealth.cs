using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private Player player;
    public Player Player { get { return (player == null) ? player = GetComponent<Player>() : player; } }

    private void OnEnable()
    {
        Player.onPlayerDamage.AddListener(Damage);
    }

    private void OnDisable()
    {
        Player.onPlayerDamage.RemoveListener(Damage);
    }

    private void Damage(int damageAmount)
    {
        Debug.Log("Damage" + damageAmount);
    }
}


