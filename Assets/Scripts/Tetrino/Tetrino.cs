using System;
using UnityEngine;

public class Tetrino : Detail
{
    [SerializeField] private TetrinoData _tetrinoData;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = _tetrinoData.GetSprite();
    }

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

    private void TakeStep()
    {
        
    }
}
