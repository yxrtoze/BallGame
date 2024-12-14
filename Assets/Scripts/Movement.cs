using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    // create a public variable to control the speed from the UI itself
 
    public Text display;

    private int count;

    // method called during the beginning of the game
    void Start()
    {
        
        count = 0;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
          
            count += 1;
            display.text = "Coins: " + count.ToString();
        }
    }

}