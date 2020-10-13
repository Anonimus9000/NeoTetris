using UnityEngine;

[CreateAssetMenu(fileName = "New Tetrino Data", menuName = "Tetrino Data", order = 51)]
public class TetrinoData : ScriptableObject
{
    [SerializeField] private string _name;
    
    [SerializeField] private Sprite _sprite;

    public Sprite GetSprite()
    {
        return _sprite;
    }
}