using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InputControls;

public class ScriptCamera : MonoBehaviour
{

    public float RotateSpeed = 1;
    public Spawner spawn;
    public bool Pause;
    public float clickBuffer = 1;
    public bool useDebounce = true;
    
    private Controls controls;

    void Start()
    {
        controls = new Controls();
        controls.Enable();
    }

    public bool Debounce = false;

    // Update is called once per frame
    void Update()
    {
        if ((controls.MouseInput.tap.ReadValue<float>() > 0 || controls.TouchInput.tap.ReadValue<float>() > 0) && Debounce == false)
        {
            Debounce = true;
            Vector2 tapPosition = new Vector2(controls.MouseInput.tapPosX.ReadValue<float>(), controls.MouseInput.tapPosY.ReadValue<float>());
            if (controls.TouchInput.tap.ReadValue<float>() > 0) 
                tapPosition = new Vector2(controls.TouchInput.tapPosX.ReadValue<float>(), controls.TouchInput.tapPosY.ReadValue<float>());

            Vector2 finalPos = Camera.main.ScreenToWorldPoint(tapPosition);

            Camera.main.GetComponent<ScriptCamera>().Pause = true;
            //Collider2D touchedCol = Physics2D.OverlapPoint(clickPos);
            Collider2D touchedCol = Physics2D.OverlapCircle(finalPos, clickBuffer);
            if (touchedCol != null) {
                Destroy d;
                if (touchedCol.TryGetComponent<Destroy>(out d))
                {
                    d.onClick();
                }
            }
            Camera.main.GetComponent<ScriptCamera>().Pause = false;
        } else if (controls.MouseInput.tap.ReadValue<float>() == 0 && controls.TouchInput.tap.ReadValue<float>() == 0) {
            Debounce = false;
        }
        
        if (useDebounce == false) Debounce = false;

        if (spawn.Paused == false && Pause == false)
        {
            transform.Rotate(0, 0, RotateSpeed*Time.deltaTime);
        }else if (Pause == true)
        {
            Pause = true;
        }
    }
}
