﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plyaer_StardustWeaponControl : MonoBehaviour
{
    public GameObject[] baseBullets = new GameObject[3];
    public int baseBulletLevel = 0;
    public float weaponCD;
    float currentWeaponCD = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        currentWeaponCD -= Time.fixedDeltaTime;
        if (currentWeaponCD <= 0)
        {
            Fire();
            currentWeaponCD = weaponCD;
        }
    }

    private void Fire()
    {
        baseBullets[baseBulletLevel].transform.position = transform.position;
        Instantiate(baseBullets[baseBulletLevel]);
    }

    public void WeaponLevelUp()
    {
        baseBulletLevel += Math.Min(2, baseBulletLevel + 1);
    }
}
