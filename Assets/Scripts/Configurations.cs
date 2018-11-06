using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configurations : MonoBehaviour {

    private static Dictionary<int, int[]> missionSizes = new Dictionary<int, int[]>();
    private static Dictionary<int, int[]> requiredFails = new Dictionary<int, int[]>();
    private static Dictionary<int, int> numSpies = new Dictionary<int, int>();
    private static int numPlayers, minPlayers = 5, maxPlayers = 10, numMissions = 5;

    static Configurations()
    {
        missionSizes.Add(5, new int[] { 2, 3, 2, 3, 3 });
        missionSizes.Add(6, new int[] { 2, 3, 4, 3, 4 });
        missionSizes.Add(7, new int[] { 2, 3, 3, 4, 4 });
        missionSizes.Add(8, new int[] { 3, 4, 4, 5, 5 });
        missionSizes.Add(9, new int[] { 3, 4, 4, 5, 5 });
        missionSizes.Add(10, new int[] { 3, 4, 4, 5, 5 });

        requiredFails.Add(5, new int[] { 1, 1, 1, 1, 1 });
        requiredFails.Add(6, new int[] { 1, 1, 1, 1, 1 });
        requiredFails.Add(7, new int[] { 1, 1, 1, 2, 1 });
        requiredFails.Add(8, new int[] { 1, 1, 1, 2, 1 });
        requiredFails.Add(9, new int[] { 1, 1, 1, 2, 1 });
        requiredFails.Add(10, new int[] { 1, 1, 1, 2, 1 });

        numSpies.Add(5, 2);
        numSpies.Add(6, 2);
        numSpies.Add(7, 3);
        numSpies.Add(8, 3);
        numSpies.Add(9, 3);
        numSpies.Add(10, 4);
    }

    public static int getMissionCount()
    {
        return numMissions;
    }

    public static int getPlayerCount()
    {
        return numPlayers;
    }

    public static void setPlayerCount(int playerCount)
    {
        numPlayers = (playerCount > maxPlayers || playerCount < minPlayers)
            ? minPlayers : playerCount;
    }

    public static int getMissionSize(int Mission)
    {
        return missionSizes[numPlayers][Mission];
    }

    public static int getRequiredFails(int Mission)
    {
        return requiredFails[numPlayers][Mission];
    }

    public static int getResistanceCount()
    {
        return maxPlayers - getSpyCount();
    }

    public static int getSpyCount()
    {
        return numSpies[numPlayers];
    }
}
