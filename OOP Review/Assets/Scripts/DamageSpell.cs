/*
 * (Jacob Welch)
 * (DamageSpell)
 * (Assignment 1 - OOP Review)
 * (Description: A spell for damaging things.)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpell : Spell, IDealDamage
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
    public DamageSpell(string name, string vfx, float cooldown, int manaCost, int damage)
    {
        this.name = name;
        this.vfx = vfx;
        this.cooldown = cooldown;
        this.manaCost = manaCost;
        this.damage = damage;
    }

    /// <summary>
    /// Performs the action of a damage spell.
    /// </summary>
    public override void PerformAction()
    {
        base.PerformAction();

        DealDamage();
    }

    /// <summary>
    /// Shows the VFX for a damage spell.
    /// </summary>
    public override void ShowVFX()
    {
        Debug.Log("Showing damage vfx: " + vfx);
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
