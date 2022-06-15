using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loader : MonoBehaviour
{
    public GameObject gameManager;
    
    void Awake()
    {
    if (GameManager.instance == null)
            Instantiate(gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Loader1 
{
    public enum Scene {
        Main,
    }

    public static void Load(Scene scene) {
        SceneManager.LoadScene(scene.ToString());
    }
}