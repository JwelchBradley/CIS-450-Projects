/*
 * (Jacob Welch)
 * (Simulator)
 * (Assignment 1 - OOP Review)
 * (Description: simulates all the actions of the spells.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    #region Fields
    private List<Spell> spells = new List<Spell>();
    private List<IPlayerAction> playerActions = new List<IPlayerAction>();
    #endregion

    #region Functions
    /// <summary>
    /// Handles initilization of components and other fields before the first frame.
    /// </summary>
    private void Start()
    {
        InitializeSpells();
        InitializePlayerActions();
    }

    /// <summary>
    /// Instantiates all the spells with their data.
    /// </summary>
    private void InitializeSpells()
    {
        // Two damage spells
        spells.Add(new DamageSpell("Water Beam", "Water Stream", 2.0f, 10, 40));
        spells.Add(new DamageSpell("Death Blast", "Dark Projectile", 5.0f, 100, 300));

        // Two movement spells
        spells.Add(new MovementSpell("Arcane Dodge", "Dash Lines", 10.0f, 50, 5.0f));
        spells.Add(new MovementSpell("Teleport", "Wooshing Portal", 30.0f, 200, Mathf.Infinity));

        // Trap spell
        spells.Add(new TrapSpell("Bear Trap", "Bear Trap Model", 10.0f, 25, 75));
    }

    /// <summary>
    /// Adds all of the spells to the IPlayerAction interface list.
    /// </summary>
    private void InitializePlayerActions()
    {
        foreach(IPlayerAction playerAction in spells)
        {
            playerActions.Add(playerAction);
        }
    }

    /// <summary>
    /// Calls for an event to take place once per frame.
    /// </summary>
    private void Update()
    {
        // Calls all of the abstract methods
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(Spell spell in spells)
            {
                spell.ShowVFX();
            }
        }

        // Calls all of the interface methods
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IPlayerAction action in playerActions)
            {
                action.PerformAction();
            }
        }
    }
    #endregion
}
