using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Transform weaponObjectsContainer;

    [SerializeField] WeaponData startingWeapon;

      private void Start() {
        {
            AddWeapon(startingWeapon);
        }
    }

    public void AddWeapon(WeaponData weaponData)
    {
        GameObject weaponGameObj = Instantiate(weaponData.weaponBaseprefab, weaponObjectsContainer);
        weaponGameObj.GetComponent<WeaponBase>().SetData(weaponData);
        CharacterStats CharacterStats = GetComponent<CharacterStats>(); 
        if(CharacterStats !=null)
        {
            CharacterStats.AddUpgradesIntoTheListOfAvaliableUpgrades(weaponData.upgrades);
        }
    }
}
