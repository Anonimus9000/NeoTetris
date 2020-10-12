using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tetrino : ITetrino
{
    
    protected float speed = 1f;

    public abstract void StartFall();
}
