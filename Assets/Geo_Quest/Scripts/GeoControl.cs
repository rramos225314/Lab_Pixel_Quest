using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoControl : MonoBehaviour
{
    public string variable0 = "Geo_Quest_Scene_2";
    int Bread = 5;
    int variable1 = 0;
    string World = "Hello";  // Start is called before the first frame update
    private Rigidbody2D rb;

    private SpriteRenderer color_Changer;
    
    void Start()
    {
        color_Changer = GetComponent<SpriteRenderer>();
        string variable2 = "World";
        Debug.Log(World + Bread);
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(variable0);

                    break;
                }
        }
    }




    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * Bread, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity += new Vector2(-1, rb.velocity.y);


        }

        if (Input.GetKeyDown(KeyCode.T))
        {
          

            color_Changer.color = new Color(0, 1, 0);

            
        }
        
        
        if (Input.GetKeyDown(KeyCode.Y))
        {

            color_Changer.color = new Color(0, 0, 1);


        } 
        
        
        
        if (Input.GetKeyDown(KeyCode.U))
        {
            color_Changer.color = new Color(1, 0, 0);
        }
            
            /*
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3 (0, -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3 (-1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3 (1, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3 (0, 1, 0);
            }
                Debug.Log(variable1 ++);
            //transform.position += new Vector3 (0.005f, 0, 0);
        */
        }
    

}
