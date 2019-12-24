using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLevel1 : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("click");
            Application.LoadLevel("Level1");
    }
}
