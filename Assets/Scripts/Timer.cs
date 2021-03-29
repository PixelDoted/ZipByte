using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public float EndTime = 10;
    public float GameTime = 0;
    public bool StartTimer = false;

    public Spawner spawn;
    public Buttons but;
    public TextMeshProUGUI TimeObject;
    private float FakeTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (StartTimer == true)
        {
            GameTime += Time.deltaTime;
            FakeLoader();
            TimeObject.SetText(Mathf.Ceil(FakeTime).ToString());
            if (GameTime >= EndTime)
            {
                StartTimer = false;
                GameTime = 0;
                but.Quited = true;
            }
            
        }
    }

    public void FakeLoader()
    {
        FakeTime = EndTime - GameTime;
    }
}
