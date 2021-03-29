using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour
{

    public float RotateSpeed = 1;
    public Spawner spawn;
    public bool Pause;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn.Paused == false && Pause == false)
        {
            if (spawn.LevelUpd == true)
            {
                transform.Rotate(0, 0, RotateSpeed * 4);
            }
            else
            {
                transform.Rotate(0, 0, RotateSpeed);
            }
        }else if (Pause == true)
        {
            Pause = true;
        }
    }

    public void LevelUp()
    {
        
    }
}
