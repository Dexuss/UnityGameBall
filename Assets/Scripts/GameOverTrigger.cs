using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            string levelName = Application.loadedLevelName;
            Application.LoadLevel(levelName);
        }
    }
}
