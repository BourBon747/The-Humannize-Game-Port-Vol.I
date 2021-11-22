using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class DayNightCycleController : MonoBehaviour
{
    [SerializeField] private Gradient lightColor;
    [SerializeField] private GameObject light;

    private int days;
    public int Days => days;
    public int getDays;
    private float time = 50;
    private bool canChangeDay = true;
    public delegate void OndayChanged();
    public OndayChanged DayChanged;


    private void Update()
    {
        //time += Time.deltaTime *100;
        //if (time > 500)
        //{
        //    light.GetComponent<Light2D>().color = lightColor.Evaluate(time * 0.002f);
        //    //time = 0;
        //}
        //if (time >= 250 && canChangeDay)
        //{
        //    canChangeDay = false;
        //    DayChanged();
        //    days++;

        //    if (time >= 255)
        //        canChangeDay = true;

        //    //time += Time.deltaTime;
        //    light.GetComponent<Light2D>().color = lightColor.Evaluate(time * 0.002f);
        //}
    }
}
