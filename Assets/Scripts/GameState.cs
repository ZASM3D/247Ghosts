using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameState : object
{
    private static GameManager manager;
    private static GameObject player;

    public static GameManager Manager {
        get { return manager; }
        set { manager = value; }
    }

    public static GameObject Player {
        get { return player; }
        set { player = value; }
    }
}
