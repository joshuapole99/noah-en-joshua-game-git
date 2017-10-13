using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losingscene : MonoBehaviour
{
    [SerializeField] private string runnerscene;
    private string loadrunnerscene;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadrunnerscene);
        }
    }
}