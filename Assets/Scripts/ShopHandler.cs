using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro;

public class ShopHandler : MonoBehaviour
{

    public string NoCoinstxt = "1B i guess?";
    public Vector3[] IDPrice; // x = ID, y = CoinsPrice, z = MoneyPrice
    public GameObject[] Object; // ID = Array number
    public TextMeshProUGUI Coinstxt;
    public GameObject BuyMenu;
    public GameObject ForceCanceled;
    public TextMeshProUGUI ForceCancelMsg;

    private int ID;
    public bool[] HasItem; // ID = Array number
    public bool DevMode;
    public GameObject CoinsStore;
    public Scores score;

    private int BuyID = 32767;
    private bool BuyMenuOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        if (DevMode == true)
        {
            CoinsStore.SetActive(false);
        }
    }

    public void BUY(int ID)
    {
        if (BuyMenuOpen == false && BuyID == 32767)
        {
            Coinstxt.SetText(IDPrice[ID].y.ToString());
            BuyMenuOpen = true;
            BuyID = ID;
            BuyMenu.SetActive(true);
        }
    }

    public void BoughtV()
    {
        if (HasItem[BuyID] == false)
        {
            if (BuyMenuOpen == true && BuyID != 32767)
            {
                if (score.Coins >= IDPrice[BuyID].y)
                {
                    Coinstxt.SetText(NoCoinstxt);
                    HasItem[BuyID] = true;
                    score.Coins = score.Coins - IDPrice[BuyID].y;
                    BuyMenuOpen = false;
                    BuyMenu.SetActive(false);
                    SaveItems();
                }
                else
                {
                    ForceCancelMsg.SetText("You do not have enough coins D=");
                    ForceCanceled.SetActive(true);
                    Cancel();
                }
            }
        }
        else
        {
            ForceCancelMsg.SetText("You already own this item =D");
            ForceCanceled.SetActive(true);
            Cancel();
        }
    }

    public void Cancel()
    {
        BuyMenuOpen = false;
        BuyMenu.SetActive(false);
        BuyID = 32767;
        SaveItems();
    }

    private void SaveItems()
    {
        if (BuyID != 32767)
            score.HasItem[BuyID] = HasItem[BuyID];
        score.SaveQuit();
        BuyID = 32767;
    }
    
}
