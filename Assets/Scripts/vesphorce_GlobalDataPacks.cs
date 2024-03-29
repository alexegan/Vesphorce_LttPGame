﻿using System;
/*
 * Contains enums that are used in many locations.
 * 
 */
 namespace vesphorce_GlobalDataPacks
{
	/// <summary>
	/// The type of object that is dealing damage.
	/// </summary>
	public enum DamageSource
    {
        Player,
        Enemy,
        Environment,
        Other
    };

	/// <summary> 
	/// A payload struct that can be delivered to the object receiving damage.
	/// 
	/// In other words, this is what the Player wants from an Enemy when the Enemy hits the Player.
	/// Enemies can receive this payload from the Player, and both can receive payloads from any source defined in DamageSource) 
	/// </summary>
	public struct DamageSourcePayload
    {
        public int DamageDealt;
        public float KnockbackDistance;
        public float StunDurationInSeconds;
        public int InvulnerabiltyFramesGranted;
    }

	/// <summary> 
	/// An enum for storing the direction a character is facing. 
	/// TODO: Change to a small class that isn't bad. 
	/// </summary>
    public enum CharacterFacingDirection
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    };

}