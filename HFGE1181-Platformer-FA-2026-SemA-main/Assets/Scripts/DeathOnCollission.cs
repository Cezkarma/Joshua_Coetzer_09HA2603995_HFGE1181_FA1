using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class DeathOnCollission : MonoBehaviour
{
    private string sceneName;
    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name; 
        Debug.Log("Current scene: " + sceneName);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Collided with " + col.gameObject.name);
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player collided with " + gameObject.name + ". Reloading scene: " + sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}
