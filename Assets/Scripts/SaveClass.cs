using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//SAVE
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//LOAD

public static class SaveClass
{

    public static void Save(Scores score)
    {
        string path = Application.persistentDataPath + "/dat.Byte";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(path, FileMode.Create);

        GameData data = new GameData(score);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData Load()
    {
        string path = Application.persistentDataPath + "/dat.Byte";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;

            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("Load file ERROR: File dosen't exist, path: " + Application.persistentDataPath + "/dat.Byte");
            return null;
        }
    }
}

[System.Serializable]
public class GameData
{
    public float HighScore;
    public float Coins;
    public bool[] HasItem;

    public bool Hardmode = false;
    public byte[] audioclip;
    public float[] backRGB = new float[3];
    public float[] musicRGB = new float[3];
    public int QualityID = 0;

    public GameData(Scores score)
    {
        HighScore = score.HighScore;
        Coins = score.Coins;
        HasItem = score.HasItem;

        Hardmode = score.Hardmode;
        audioclip = score.audioclip;
        backRGB = score.backRGB;
        musicRGB = score.musicRGB;
        QualityID = score.QualityID;
    }
}