using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public String levelName;
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
