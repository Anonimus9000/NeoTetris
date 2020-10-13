using System;
using UnityEngine;

public class Tetrino : Detail
{
    private Rigidbody2D _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void StartFall()
    {
        _rigidbody.velocity = new Vector2(-1f * speed, _rigidbody.velocity.x);
    }

    public override void SetSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    private void TakeStep()
    {
        
    }
}
