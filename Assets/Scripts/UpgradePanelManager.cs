using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanelManager : MonoBehaviour
{
    [SerializeField] GameObject panel;
    PauseManager pauseManager;
    [SerializeField] List<UpgradeButton> upgradeButtons;
     [SerializeField] GameObject Wizard;

    private void Awake() 
    {
        pauseManager = GetComponent<PauseManager>();
    }

    private void Start()
    {
        HideButtons();
    }
    public void OpenPanel(List<UpgradeData> upgradeDatas)
    {
        Clean();
        pauseManager.PauseGame();
        panel.SetActive(true);
        
        
        for(int i = 0; i<upgradeDatas.Count; i++)
        {
            upgradeButtons[i].gameObject.SetActive(true);
            upgradeButtons[i].Set(upgradeDatas[i]);
        }
    }

    public void ClosePanel()
    {
        HideButtons();
        pauseManager.UnPauseGame();
        panel.SetActive(false);
    }

    public void Upgrade(int IDpressed)
    {
        Wizard.GetComponent<CharacterStats>().Upgrade(IDpressed);
        ClosePanel();
    }

    public void Clean()
    {
        for (int i =0; i< upgradeButtons.Count; i++)
        {
            upgradeButtons[i].Clean();
        }
    }

    private void HideButtons()
    {
            for(int i=0; i< upgradeButtons.Count; i++){
            upgradeButtons[i].gameObject.SetActive(false);
        }
    }
}
