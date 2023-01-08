using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int seviye;
    public float exp;
    //const 0
    float sifir = 0;
    //seviye atlama icin gerekli exp
    public float TOLEVELUP;

    //exp slider
    [SerializeField] experiencebar experiencebar;
    [SerializeField] UpgradePanelManager upgradepanel;
    [SerializeField] List<UpgradeData> upgrades;
    List <UpgradeData> selectedUpgrades;

    [SerializeField] List <UpgradeData> acquiredUpgrades;

    WeaponManager weaponManager;
    

    //coldown yuzdeligi
    public float cooldowndp;

    DropMovement DropMovement;
    // Start is called before the first frame update
    void Start()
    {
        seviye =1;
        exp=0;
        cooldowndp =1;
        //experiencebar.SetLevelText(seviye);
    }
    void Update() {
        levelsystem();
        
        
        

    }


    void Awake() {
        weaponManager = GetComponent<WeaponManager>();
    }
        
    // Update is called once per frame
     public void levelsystem(){
        if(exp >= 100){
            LevelUP();
        }
    }
    

      private void LevelUP()
     {

        if(selectedUpgrades == null) { selectedUpgrades = new List<UpgradeData>();}
        selectedUpgrades.Clear();
        selectedUpgrades.AddRange(GetUpgrades(4));
        upgradepanel.OpenPanel(selectedUpgrades);
            seviye++;
            exp = sifir;
            //experiencebar.SetLevelText(seviye);
    }
   



    
    public void expsystem(float ExpAmount){

        exp += ExpAmount;
        //experiencebar.UpdateExperienceSlider(exp,100);
    }

    public void cooldownevent(){
        cooldowndp = 0.4f;

    }

    public List<UpgradeData> GetUpgrades(int count){
        List<UpgradeData> upgradeList = new List<UpgradeData>();

        if (count > upgrades.Count)
        {
            count = upgrades.Count;
        }
        for (int i = 0; i<count; i++){
            upgradeList.Add(upgrades[Random.Range(0, upgrades.Count)]);
        }
        

        return upgradeList;

    }
       public void Upgrade(int selectedUpgradeId){
            UpgradeData upgradeData = selectedUpgrades[selectedUpgradeId];

            if(acquiredUpgrades == null) {acquiredUpgrades = new List<UpgradeData>();}

            switch (upgradeData.upgradeType)
            {
                case UpgradeType.WeaponUpgrade:
                    break;
                case UpgradeType.ItemUpgrade:
                    break;
                case UpgradeType.WeaponUnlock:
                    weaponManager.AddWeapon(upgradeData.weaponData);
                break;
                case UpgradeType.ItemUnlock:
                break;
            }
            acquiredUpgrades.Add(upgradeData);

            upgrades.Remove(upgradeData);
    }    
     internal void AddUpgradesIntoTheListOfAvaliableUpgrades(List<UpgradeData> upgradesToAdd)
        {
            this.upgrades.AddRange(upgradesToAdd);
        }

    }

