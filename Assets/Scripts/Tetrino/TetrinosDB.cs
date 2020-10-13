using UnityEngine;

[CreateAssetMenu(fileName = "New Tetrino Data", menuName = "Tetrino Data", order = 51)]
public class TetrinosDB : ScriptableObject
{
    
    [SerializeField] private Sprite _spriteTetrinoI;
    [SerializeField] private Sprite _spriteTetrinoZ;
    [SerializeField] private Sprite _spriteTetrinoS;
    [SerializeField] private Sprite _spriteTetrinoL;
    [SerializeField] private Sprite _spriteTetrinoLA;
    [SerializeField] private Sprite _spriteTetrinoCube;
    [SerializeField] private Sprite _spriteTetrinoT;

    public Sprite GetTetrinoSpriteI()
    {
        return _spriteTetrinoI;
    }
    
    public Sprite GetTetrinoSpriteZ()
    {
        return _spriteTetrinoZ;
    }
    
    public Sprite GetTetrinoSpriteS()
    {
        return _spriteTetrinoS;
    }
    
    public Sprite GetTetrinoSpriteL()
    {
        return _spriteTetrinoL;
    }
    
    public Sprite GetTetrinoSpriteLA()
    {
        return _spriteTetrinoLA;
    }
    public Sprite GetTetrinoSpriteCube()
    {
        return _spriteTetrinoCube;
    }
    public Sprite GetTetrinoSpriteT()
    {
        return _spriteTetrinoT;
    }
}