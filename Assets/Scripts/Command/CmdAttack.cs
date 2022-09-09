using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmdAttack : ICommand
{ 
    // Propiedades del comando 
    private IGun _gun; // quien hace al attack 
 

    public CmdAttack(IGun gun) { 
        _gun = gun;
    }

    public void Execute() => _gun.Attack();
    
}
