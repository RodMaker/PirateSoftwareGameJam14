using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : Singleton<ExperienceManager>
{
    public delegate void ExperienceChangeHandler(int amount);
    public event ExperienceChangeHandler OnExperienceChange;

    protected override void Awake()
    {
        base.Awake();

        Debug.Log($"Hello i was awaken at <color=green>{Time.time}</color>");
    }

    public void AddExperience(int amount)
    { 
        OnExperienceChange?.Invoke(amount); 
    }
}
