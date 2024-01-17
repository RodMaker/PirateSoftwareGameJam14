using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceManager : Singleton<ExperienceManager>
{
    public delegate void ExperienceChangeHandler(int amount);
    public event ExperienceChangeHandler OnExperienceChange;

    public void AddExperience(int amount)
    { 
        OnExperienceChange?.Invoke(amount); 
    }
}
