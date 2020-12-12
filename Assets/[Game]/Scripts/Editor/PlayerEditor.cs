using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
  public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Player p = (Player)target;
        if (GUILayout.Button("Damage Player"))
            p.DamagePlayer();
    }
}
