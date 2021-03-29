using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardmodeHandler : MonoBehaviour
{

    public OptionsHandler options;
    public Timer time;
    public ScriptCamera Cam;
    public Scores score;
    public bool tick;
    public int ID;
    public int NormalTime = 10;
    public int HardmodeTime = 5;
    public float NormalRotate = 1;
    public float HardmodeRotate = 2;
    public int addcoins = 5;
    public int addcoinsHard = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (options.Enabled[ID] != tick)
        {
            tick = options.Enabled[ID];
            check();
        }
    }

    private void check()
    {
        if (tick == true)
        {
            Enable();
        } else if (tick == false)
        {
            Disable();
        }
    }

    private void Enable()
    {
        time.EndTime = HardmodeTime;
        Cam.RotateSpeed = HardmodeRotate;
        score.AddCoins = addcoinsHard;
    }

    private void Disable()
    {
        time.EndTime = NormalTime;
        Cam.RotateSpeed = NormalRotate;
        score.AddCoins = addcoins;
    }
}
