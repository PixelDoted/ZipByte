using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//SAVE
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//LOAD

public class Scores : MonoBehaviour
{
    public TextMeshProUGUI Scoretxt;
    public TextMeshProUGUI HighScoretxt;
    public TextMeshProUGUI Coinstxt;
    public TextMeshProUGUI ScoreHUDtxt;

    public HardmodeHandler hardmodeHandler;
    public ColorHandler colorHandler;
    public MusicHandler musicHandler;
    public AdvancedOp AdvancedHandler;

    public float Score;
    public float AddScore;
    public float HighScore;
    public float Coins;
    public float ADCoins;
    public float AddCoins;
    public Spawner spawn;
    private float CoinsScore;
    public float AddCoinsScore;
    public bool[] HasItem;
    public int HasItemSize;
    public ShopHandler Shop;
    public string AudioFile;

    public bool Hardmode = false;
    public byte[] audioclip;
    public float[] backRGB = new float[3];
    public float[] musicRGB = new float[3];
    public int QualityID = 0;

    #region Sad

    void Start()
    {
        GameData data = SaveClass.Load();

        HighScore = data.HighScore;
        Coins = data.Coins;
        if (data.HasItem.Length != 0 && Shop.DevMode == false)
        {
            for (int i = 0; i < data.HasItem.Length - 1; i++)
            {
                HasItem[i] = data.HasItem[i];
            }
        }
        else if (Shop.DevMode == true)
        {
            for (int i = 0; i < HasItem.Length; i++)
            {
                HasItem[i] = true;
            }
        }
        Shop.HasItem = HasItem;
    }

    public void SaveQuit()
    {
        SaveClass.Save(this);
    }

    #endregion

    #region UI

    void Update()
    {
        Scoretxt.SetText(Score.ToString());
        HighScoretxt.SetText(HighScore.ToString());
        Coinstxt.SetText(Coins.ToString());
        ScoreHUDtxt.SetText(Score.ToString());

        if (Score > HighScore)
        {
            HighScore = Score;
        }
        if (CoinsScore < AddCoinsScore)
        {
            CoinsScore = AddCoinsScore;
        }
        if (Score >= CoinsScore)
        {
            CoinsScore += AddCoinsScore;
            Coins += AddCoins;
        }

        if (Score == 0)
        {
            CoinsScore = AddCoinsScore;
        }
    }

    #endregion
}
