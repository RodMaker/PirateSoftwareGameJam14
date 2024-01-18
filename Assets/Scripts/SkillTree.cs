using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    [SerializeField] private int passiveSkillPoints;
    [SerializeField] private TMP_Text passiveSkillPointsText;
    [SerializeField] private GameObject skillTree;

    private bool movementSpeedPassiveUnlocked, swordAttackDamagePassiveUnlocked, bowAttackDamagePassiveUnlocked, staffAttackDamagePassiveUnlocked,
        swordAttackCooldownPassiveUnlocked, bowAttackCooldownPassiveUnlocked, staffAttackCooldownPassiveUnlocked,
        bowAttackRangePassiveUnlocked, staffAttackRangePassiveUnlocked = false;

    const string PASSIVE_SKILL_POINTS_TEXT = "PassiveSkillPointsText";

    private void Start()
    {
        passiveSkillPoints = 10; // Should be 0, just for testing purposes i am using 10 now

        UpdatePassiveSkillPointsText();

        movementSpeedPassiveUnlocked = false;
        swordAttackDamagePassiveUnlocked = false;
        bowAttackDamagePassiveUnlocked = false;
        staffAttackDamagePassiveUnlocked = false;
        swordAttackCooldownPassiveUnlocked = false;
        bowAttackCooldownPassiveUnlocked = false;
        staffAttackCooldownPassiveUnlocked = false;
        bowAttackRangePassiveUnlocked = false;
        staffAttackRangePassiveUnlocked = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            skillTree.SetActive(!skillTree.activeSelf);
        }
    }

    public void UpdatePassiveSkillPointsText()
    {
        if (passiveSkillPointsText == null)
        {
            passiveSkillPointsText = GameObject.Find(PASSIVE_SKILL_POINTS_TEXT).GetComponent<TMP_Text>();
        }

        passiveSkillPointsText.text = passiveSkillPoints.ToString("D2");
    }

    public void UpdateMovementSpeed()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && movementSpeedPassiveUnlocked == false)
        {
            movementSpeedPassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            PlayerController.Instance.moveSpeed += 2;
        }
    }

    public void UpdateSwordAttackDamage()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && swordAttackDamagePassiveUnlocked == false)
        {
            swordAttackDamagePassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateBowAttackDamage()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && bowAttackDamagePassiveUnlocked == false)
        {
            bowAttackDamagePassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateStaffAttackDamage()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && staffAttackDamagePassiveUnlocked == false)
        {
            staffAttackDamagePassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateSwordAttackCooldown()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && swordAttackCooldownPassiveUnlocked == false)
        {
            swordAttackCooldownPassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateBowAttackCooldown()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && bowAttackCooldownPassiveUnlocked == false)
        {
            bowAttackCooldownPassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateStaffAttackCooldown()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && staffAttackCooldownPassiveUnlocked == false)
        {
            staffAttackCooldownPassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateBowAttackRange()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && bowAttackRangePassiveUnlocked == false)
        {
            bowAttackRangePassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }

    public void UpdateStaffAttackRange()
    {
        if (passiveSkillPoints == 0)
        {
            return;
        }

        if (passiveSkillPoints >= 1 && staffAttackRangePassiveUnlocked == false)
        {
            staffAttackRangePassiveUnlocked = true;
            passiveSkillPoints -= 1;
            UpdatePassiveSkillPointsText();
            // Do stuff
            Debug.Log("Passive Unlocked");
        }
    }
}
