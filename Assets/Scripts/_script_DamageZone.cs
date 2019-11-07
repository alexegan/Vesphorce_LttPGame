using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using vesphorce_GlobalDataPacks;

/// <summary>
/// This script currently defines the damage zone behaviour of the sword weapon
/// </summary>
public class _script_DamageZone : MonoBehaviour
{

    public DamageSource DamageSource = DamageSource.Enemy;
    [Min(0)]
    public int DamageDealt = 1;
    [Range(0,50)]
    public float KnockbackDistance = 1f;
    [Range(0, 10)]
    public float StunDurationInSeconds = 0f;
    [Min(0)]
    [Header("60 frames per second guaranteed")]
    public int InvulnFramesGranted = 20;


    private DamageSourcePayload payload;

    // Start is called before the first frame update
    void Start()
    {
        payload.DamageDealt = DamageDealt;
        payload.KnockbackDistance = KnockbackDistance;
        payload.StunDurationInSeconds = StunDurationInSeconds;
        payload.InvulnerabiltyFramesGranted = InvulnFramesGranted;
    }

    
    public DamageSourcePayload GetPayload()
    {
        return payload;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
