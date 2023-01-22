/*
 * (Jacob Welch)
 * (MovementSpell)
 * (Assignment 1 - OOP Review)
 * (Description: A spell for moving.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpell : Spell
{
    #region Fields
    protected float speed;
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for a movement spell.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="vfx"></param>
    /// <param name="cooldown"></param>
    /// <param name="manaCost"></param>
    /// <param name="speed"></param>
    public MovementSpell(string name, string vfx, float cooldown, int manaCost, float speed)
    {
        this.name = name;
        this.vfx = vfx;
        this.cooldown = cooldown;
        this.manaCost = manaCost;
        this.speed = speed;
    }

    /// <summary>
    /// Performs a movement action spell by the player.
    /// </summary>
    public override void PerformAction()
    {
        base.PerformAction();

        Debug.Log("Move for speed: " + speed);
    }

    /// <summary>
    /// Shows movement VFX for the spell.
    /// </summary>
    public override void ShowVFX()
    {
        Debug.Log("Showing movement vfx: " + vfx);
    }
    #endregion
}
