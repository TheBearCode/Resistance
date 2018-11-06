using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour {

    private int currentMission = 0;
    private List<Mission> missions = new List<Mission>();

    void Start ()
    {
        generateMissions();
	}
	
	void Update ()
    {
		
	}

    private void generateMissions()
    {
        for (int i = 0; i < Configurations.getMissionCount(); i++)
        {
            missions.Add(new Mission(
                    Configurations.getMissionSize(i),
                    Configurations.getRequiredFails(i)));
        }
    }

    public Mission getCurrentMission()
    {
        return missions[currentMission];
    }

    public void advanceMission()
    {
        currentMission++;
    }

}


public class Mission
{
    public enum MISSION_STATUS { SUCCESS, FAIL, NONE };
    private int missionSize, requiredFails;
    private MISSION_STATUS missionStatus;

    public Mission(int missionSize, int requiredFails)
    {
        this.missionSize = missionSize;
        this.requiredFails = requiredFails;
        this.missionStatus = MISSION_STATUS.NONE;
    }

    public void setMissionStatus(MISSION_STATUS status)
    {
        missionStatus = status;
    }

    public MISSION_STATUS getMissionStatus()
    {
        return missionStatus;
    }
}