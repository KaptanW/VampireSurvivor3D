using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponStats
{
     public int damage;
    public float timeToAttack;

    public WeaponStats(int damage, float timeToAttack)
    {
        this.damage = damage;
        this.timeToAttack = timeToAttack;
    }
     
} 
[CreateAssetMenu(fileName = "Weaponmanager", menuName = "Weaponsmanager/Weapon", order = 0)]
    public class WeaponData : ScriptableObject 
{
    
    public string Name;
    public GameObject weaponBaseprefab;
    public WeaponStats stats;
    public List<UpgradeData> upgrades;


}

