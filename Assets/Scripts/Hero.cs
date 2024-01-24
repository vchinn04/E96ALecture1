using UnityEngine;
public class Hero : MonoBehaviour
{
    void Start()
    {
        /* TODO: create a variable of type int with name 'score', and assign
        a value of 20 to it */

        /* TODO: write an if-statement that checks the score (the variable
        you created above) is greater than 18. If so, print (using
        Debug.Log()) "You win!", otherwise, print "You lose" */

        /* TODO: write a while-loop that checks if the score is greater than
       10. Inside the loop, decrement the score by 1 */

        /* TODO: write a for-loop that loops a total of 4 times, starting
        from 1, and in each loop adds the value of the counter variable
        to the score */

        int score = 20;

        if (score > 18)
        {
            Debug.Log("You win!");
        }
        else
        {
            Debug.Log("You lose");
        }

        while (score > 10)
        {
            score -= 1;
        }

        for (int i = 1; i <= 4; i++)
        {
            Debug.Log(i);
        }


        Debug.Log(score);

        /* TODO: print out the final score to console */
    }
}