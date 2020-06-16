using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    //this is a class called Pet 
    int fullness = 0;
    bool asleep = false; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("click on the game window in Unity to select it"); 
        Debug.Log("Press f to feed");
        Debug.Log("Press c to cuddle"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F)) //This is how unity checks for key input. Youc can put any letter on your keyboard here 
        {
            feed(); //call the feed function. Feed that critter! 
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            cuddle(); //pet that cat!
        }


        if (fullness > 10 && fullness < 20) //if statements are really cool! You can stack conditions together just using &&
        {
            Debug.Log("This is good! Meow! Soon, I will fall sleep happy in the sun."); 
        }

        if (fullness > 20) {
            asleep = true; 
            Debug.Log("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz"); 
        }
 
    }

    void feed()
    {
        if (asleep == false)
        {
            fullness = fullness + 1; //food is good and makes you full! add 1 to fullness 
            Debug.Log("Nom, nom, nom");
        }
        
    }

    //hot tip! You can't name a function the same as your class. That's a reserved function called a constructor. Google dotnetperals and constructor to learn more but you don't need it in this class. 
    void cuddle() {
        Debug.Log("Pur, pur"); 
    }

}
