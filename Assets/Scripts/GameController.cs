using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController 
    : MonoBehaviour
{
    private MissionManager missionManager;
    
	// Use this for initialization
	void Start (int playerCount)
    {
        Configurations.setPlayerCount(playerCount);
        missionManager = new MissionManager();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}


