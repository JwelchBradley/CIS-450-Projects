/*
 * (Jacob Welch)
 * (Spell)
 * (Assignment 1 - OOP Review)
 * (Description: An abstract class for all spells.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : IPlayerAction
{
    #region Fields
    protected string name;
    protected float cooldown;
    protected int manaCost;
    protected string vfx;
    #endregion

    #region Functions
    /// <summary>
    /// Performs the action of the spell.
    /// </summary>
    public virtual void PerformAction()
    {
        Debug.Log("Performing spell: " + name);
        Debug.Log("Using Mana: " + manaCost);
        Debug.Log("Waiting cooldown: " + cooldown);

        ShowVFX();
    }

    /// <summary>
    /// Shows a VFX for when the spell happens.
    /// </summary>
    public abstract void ShowVFX();
    #endregion
}
