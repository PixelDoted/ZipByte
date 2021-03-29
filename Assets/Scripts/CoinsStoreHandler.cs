using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsStoreHandler : MonoBehaviour
{

    public Scores score;

    public void Completed(int amountCoins)
    {
        score.Coins += amountCoins;
        score.SaveQuit();
    }

}
