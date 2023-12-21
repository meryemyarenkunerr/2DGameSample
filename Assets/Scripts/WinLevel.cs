using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    private Scene _scene;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
    public void StartLevel()
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
