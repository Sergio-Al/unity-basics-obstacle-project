using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    float times = 0;
    Regex rx = new Regex(@"^[wW]all");
    string message;

    private void OnCollisionEnter(Collision other)
    {
       WallBumped(other);
    }

    void WallBumped(Collision myother){
         MatchCollection col = rx.Matches(myother.gameObject.name);
        if (col.Count > 0)
        {
            times++;
            message = "You've bumpe a wall " + times + " " + (times <= 1 ? " time" : " times");
        }
        else {
            message = "You've bumped other thing";
        }
        Debug.Log(message);
    }
}
