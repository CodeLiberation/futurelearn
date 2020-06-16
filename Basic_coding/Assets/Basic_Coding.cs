using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is a class in Unity. It is called Basic_Coding, which is the name of our script. MonoBehavior is it's parent. All you need to know is it means you can use the Unity Engine for now. Search dotnetpearls + inheritance after this class if you're really curious!
public class Basic_Coding : MonoBehaviour
{
    //comments are super useful! The engine will ignore any line with // at the start. You could write a whole novel here and it'd ignore you! 

    // VARIABLES:
    int percentageCaffinated; // The integer variable "percentageCaffinated" holds a whole number 

    // Start is called before the first frame update and only once
    void Start()
    {
        percentageCaffinated = 0; // Let's save the number 0 because there's no coffee in our body yet. Let's change that STAT! 

        wakeUp(); //wakey wakey sleephead
    }

    void wakeUp() {
        //FOR LOOPS: for as long as a condition is true, do a thing. Until you are awake, drink some coffee! 
        for (int i = 0; i < 101; i++)
        { // For each of the numbers 0 through 100
            percentageCaffinated = i;
            //add one to i each time through the loop. 
        }
    }

    //Unity runs update every frame, usually about 1/60th of a second.
    void Update()
    {
        //because no one should do math homework tired.... 
        if (percentageCaffinated == 100) //a double == checks to see if two values are the same :D 
        {
            int answer = doYourMathHomework(13, 23);
           // Debug.Log(answer);  (Uncomment to see the answer!) 
        }
    }

    //FUNCTIONS:
    int doYourMathHomework(int a, int b)
    {
        int sum = a + b; // The answer is the sum of the two numbers.
        return sum; // Returns the sum of a+b to the location in the code that called it, in this case, line 36. 
    }

  }
