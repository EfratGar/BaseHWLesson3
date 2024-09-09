using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
// give meaningful names to classes
public class NewBehaviourScript : MonoBehaviour
{
    //Create a method that accepts an integer, operates it and prints out the result:

    int MethodThatOperates(int number)
    {
        int result = number + 1;
        return result;
    }

    //Create a method that accepts an integer, with an if statement about this integer.
    //Print something inside the if body, and inside the else body: 

    void IfMethod(int result)
    {
        if (result >= 4)
        {
            Debug.Log(result + " is bigger than or equal to " + 4); 
        }

        else
        {
            Debug.Log(result + " is smaller than " + 4);
        }
    }

    //Create a method that accepts an integer, with a switch statement with 3 cases about this integer. Print something in the cases:

    void MethodWithSwitches(int hp)
    {
        switch (hp)
        {
            case 1:
                Debug.Log("You are going to die! Heal NOW!!!!!!!!!");
                break;
            case 2:
                Debug.Log("You hp is too LOW!! You have to heal NOW!");
                break;
            case 3:
                Debug.Log("Your hp could be better, try to find a potion.");
                break;
            case 4:
                Debug.Log("Your hp is almost perfect!");
                break;
            case 5:
                Debug.Log("Your hp is FANTASTIC!!! Well Done!");
                break;
            default:
                Debug.Log("GAME OVER!!! U R DEAD!!!");
                break;
        }

    }
//perfect
    void Start()
    {
        //Create a method that accepts an integer, operates it and prints out the result:
        int number = Random.Range(1, 5);
        int finalResult = MethodThatOperates(number);
        int hp = finalResult;

        Debug.Log("The random number that was chosen out of 5 is : " + number);
        Debug.Log("After adding 1, the final result is: " + finalResult);

        //Create a method that accepts an integer, with an if statement about this integer:
     
        IfMethod(finalResult);

        //Create a method that accepts an integer, with a switch statement with 3 cases about this integer. Print something in the cases:
        MethodWithSwitches(hp);
    }
}
