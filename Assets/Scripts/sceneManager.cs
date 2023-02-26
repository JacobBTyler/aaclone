using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sceneManager : MonoBehaviour
{


    public static float pinSpeed;

    public static float rotatorSpeed;
    public static int pinRotColor;

    public static string playerName;

    public Slider pinSlider;
    public Slider rotSlider;
    public GameObject pname;

    public TMP_Dropdown color;

    // Start is called before the first frame update
    void Start()
    {
        pinSpeed = 1.0f;

        rotatorSpeed = 1.0f;

        pinRotColor = 0;

        playerName = "Player";


    }

    public void updateValues()
    {
        pinSpeed = pinSlider.value;
        rotatorSpeed = rotSlider.value;
        playerName = pname.GetComponent<UnityEngine.UI.Text>().text;
        pinRotColor = color.value;
    }

 


}
