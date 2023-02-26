using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dropdown : MonoBehaviour
{
    public TMP_Dropdown theDropdown;
   public void setDropdown()
   {
        sceneManager.pinRotColor = theDropdown.value;
   }
}
