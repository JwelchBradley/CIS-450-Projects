/*
 * (Jacob Welch)
 * (TrapSpell)
 * (Assignment 1 - OOP Review)
 * (Description: A spell that places traps)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpell : Spell, IDealDamage
{
    #region Fields
    private int damage;
    #endregion

    #region Functions
    /// <summary>
    /// A constructor for damage spells.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="vfx"></param>
    /// <param name="cooldown"></param>
    /// <param name="manaCost"></param>
    /// <param name="damage"></param>
    public TrapSpell(string name, string vfx, float cooldown, int manaCost, int damage)
    {
        this.name = name;
        this.vfx = vfx;
        this.cooldown = cooldown;
        this.manaCost = manaCost;
        this.damage = damage;
    }

    /// <summary>
    /// Performs the action of a trap spell.
    /// </summary>
    public override void PerformAction()
    {
        base.PerformAction();

        DealDamage();
    }

    /// <summary>
    /// Shows the VFX for a trap spell.
    /// </summary>
    public override void ShowVFX()
    {
        Debug.Log("Showing trap spell vfx: " + vfx);
    }

    /// <summary>
    /// Deals damage to something.
    /// </summary>
    public void DealDamage()
    {
        Debug.Log("Dealt Damage: " + damage);
    }
    #endregion
}
