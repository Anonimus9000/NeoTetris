using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrinoSpawner : MonoBehaviour
{
    [SerializeField] private Detail detailZPrefab;
    [SerializeField] private Detail detailSPrefab;
    [SerializeField] private Detail detailIPrefab;
    [SerializeField] private Detail detailCubePrefab;
    [SerializeField] private Detail detailTPrefab;
    [SerializeField] private Detail detailLPrefab;
    [SerializeField] private Detail detailLAPrefab;

    [SerializeField] private TetrinosDB _tetrinosDb;

    private void SetTetrinosSprites()
    {
        detailZPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteZ());
        detailSPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteS());
        detailIPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteI());
        detailCubePrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteCube());
        detailTPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteT());
        detailLPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteL());
        detailLAPrefab.SetSprite(_tetrinosDb.GetTetrinoSpriteLA());
    }
}
