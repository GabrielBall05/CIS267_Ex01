using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Get rid of : Mono Behavior and add static for our GameManager
public static class GameManager 
{
    private static int playerMovementSpeed;

    public static int getPlayerMovementSpeed()
    {
        return playerMovementSpeed;
        //When you do your typical movement, you'll call GameManager.getPlayerMovementSpeed() instead
    }
}
