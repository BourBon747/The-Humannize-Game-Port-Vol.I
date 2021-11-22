using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            string screenshotname;
            int randomNumber = Random.Range(0, 10000);
            screenshotname = "ScreenShot" + randomNumber + ".png";
            ScreenCapture.CaptureScreenshot(screenshotname);

            Debug.Log(" You have taken your scene !!!");
        }
    }
}
