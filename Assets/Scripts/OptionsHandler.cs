using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OptionsHandler : MonoBehaviour
{

    public bool[] Enabled;
    public TextMeshProUGUI[] Recolored; //if blank then the id isn't a Text 
    public int[] ShopID; //if blank then this option is not avalable on the shop page
    public GameObject[] OpenableUIs; // if blank then the id dosen't have a uiMenu
    public bool[] OpenedUIs;
    public bool[] ShopEnabled;
    public string[] Type;
    public Color EnabledColor;
    public Color DisabledColor;
    public ShopHandler Shop;
    public GameObject AudioS;

    public void EnableThis(int ID)
    {
        if (ShopEnabled[ID] == false || ShopEnabled[ID] == true && Shop.HasItem[ShopID[ID]] == true)
        {
            Enabled[ID] = !Enabled[ID];
            if (Recolored[ID] != null)
            {
                if (Enabled[ID] == true)
                {
                    Recolored[ID].color = EnabledColor;
                    Loaders(ID, true);
                }
                else if (Enabled[ID] == false)
                {
                    Recolored[ID].color = DisabledColor;
                    Loaders(ID, false);
                }
            }
        }
    }

    public void openUI(int ID)
    {
        if (ShopEnabled[ID] == false || ShopEnabled[ID] == true && Shop.HasItem[ShopID[ID]] == true)
        {
            if (OpenableUIs[ID] != null)
            {
                if (OpenedUIs[ID] == false)
                {
                    OpenedUIs[ID] = true;
                    OpenableUIs[ID].SetActive(true);
                }
            }
        }
    }

    public void closeUI(int ID)
    {
        if (OpenableUIs[ID] != null)
        {
            if (OpenedUIs[ID] == true)
            {
                OpenedUIs[ID] = false;
                OpenableUIs[ID].SetActive(false);
            }
        }
    }

    public void Loaders(int ID, bool Enable)
    {
        if (Type[ID] == "Music")
        {
            if (Enable == true)
            {
                if (AudioS.GetComponent<AudioSource>().clip != null)
                {
                    AudioS.SetActive(true);
                }
                else if (AudioS.GetComponent<AudioSource>().clip == null)
                {
                    Recolored[ID].color = DisabledColor;
                }
            }
            else if (Enable == false)
            {
                AudioS.SetActive(false);
            }
        }
        else if (Type[ID] == "Val")
        {
            for (int i = 0; i < Val.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(3);
                    Val[i].SetActive(true);
                }
                else
                {
                    Val[i].SetActive(false);
                }
            }
        }
        else if (Type[ID] == "Hal")
        {
            for (int i = 0; i < Hal.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(4);
                    Hal[i].SetActive(true);
                }
                else
                {
                    Hal[i].SetActive(false);
                }
            }
        }
        else if (Type[ID] == "Tha")
        {
            for (int i = 0; i < Tha.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(5);
                    Tha[i].SetActive(true);
                }
                else
                {
                    Tha[i].SetActive(false);
                }
            }
        }
        else if (Type[ID] == "Chr")
        {
            for (int i = 0; i < Chr.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(6);
                    Chr[i].SetActive(true);
                }
                else
                {
                    Chr[i].SetActive(false);
                }
            }
        }
        else if (Type[ID] == "Vth")
        {
            for (int i = 0; i < Vth.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(7);
                    Vth[i].SetActive(true);
                }
                else
                {
                    Vth[i].SetActive(false);
                }
            }
        }
        else if (Type[ID] == "CBi")
        {
            for (int i = 0; i < CBi.Length; i++)
            {
                if (Enable == true)
                {
                    Disable(8);
                    CBi[i].SetActive(true);
                }
                else
                {
                    CBi[i].SetActive(false);
                }
            }
        }
    }

    public GameObject[] Val;
    public GameObject[] Hal;
    public GameObject[] Tha;
    public GameObject[] Chr;
    public GameObject[] Vth;
    public GameObject[] CBi;

    public void Disable(int ID)
    {
        if (Enabled[8] == true && ID != 8)
        {
            EnableThis(8);
        }
        else if (Enabled[7] == true && ID != 7)
        {
            EnableThis(7);
        }
        else if (Enabled[6] == true && ID != 6)
        {
            EnableThis(6);
        }
        else if (Enabled[5] == true && ID != 5)
        {
            EnableThis(5);
        }
        else if (Enabled[4] == true && ID != 4)
        {
            EnableThis(4);
        }
        else if (Enabled[3] == true && ID != 3)
        {
            EnableThis(3);
        }
    }

}
