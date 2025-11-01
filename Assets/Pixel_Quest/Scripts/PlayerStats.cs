using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{

    public string nextlevel = "GeoLevel_2";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

            case "Death":
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    break;
                }

                void Update()
                {

                }
        }
    } } 
