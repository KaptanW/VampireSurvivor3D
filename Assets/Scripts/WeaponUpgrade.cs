using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UpgradeType
{
    WeaponUpgrade,
    ItemUpgrade,
    WeaponUnlock,
    ItemUnlock
}

[CreateAssetMenu(fileName = "WeaponUpgrade", menuName = "Weapon/WeaponUpgrade", order = 1)]
public class UpgradeData : ScriptableObject {
    public UpgradeType upgradeType;
    public string Name;
    public Sprite icon;

    public WeaponData weaponData;
    
    
}
