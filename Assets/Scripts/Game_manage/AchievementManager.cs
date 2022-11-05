/*
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public enum Achievement
    {
        GameStart,
        GameOver,

    }
    class AchievementsComparer : IEqualityComparer<Achievements>
    {
        public bool Equals(Achievements a, Achievements b)
        {
            return a == b;       
        }
    }
    public int GetHashCode(Achievement obj)
    {
        return((int)obj).GetHashCode();
    }
}
static AchievementManager _instance;

public static AchievementManager Instance
{
    get
    {
        if(_instance == null)
        {
            GameObject obj = new GameObject("AchievementManager");
            _instance = obj.AddComponent<AchievementManager>();
            DontDestroyOnLoad(obj);
        }
        return _instance;
    }
}
Dictionary<Achievements, bool> _dicAchievementUnlock =
    new Dictionary<Achievements, bool>(new AchievementsComparer());
public void OnNotify(Achievements achv, int GS = 0, int GO = 0)
{
    switch(achv)
    {
        case Achievements.Start:
            UnlockGameStart(GS);
            break;
        case Achievements.GameOver:
            UnlockGameStart(GO);
            break;
    }
}
public AchievementManager()
{
    foreach(Achievements achv in enum.GetValues(typeof(Achievements)))
    {
        _dicAchievementUnlock[achv] = false;
    }
}
void UnlockGameStart(int StartGame)
{
    if( _dicAchievementUnlock[Achievements.Start])
        return;
    if(OnBtnClick.GameStart)
    {
        Debug.Log("Fiest Slash");
        _dicAchievementUnlock[Achievements.Start] = true;
    }
}
*/