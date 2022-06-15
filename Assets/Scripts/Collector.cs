using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.Mathematics;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [Header("Ref")] public Transform ItemHolderTransform;

    private int NumberOfItemsHolding = 0;
    
    public void AddNewItem(Transform _itemToAdd)
    {
        

        _itemToAdd.DOJump(ItemHolderTransform.position + new Vector3(0, 0.025f * NumberOfItemsHolding, 0),1.5f,1,.25f).OnComplete(() =>
        {
            _itemToAdd.SetParent(ItemHolderTransform,true);
            _itemToAdd.localPosition = new Vector3(0, 0.025f * NumberOfItemsHolding, 0);
            _itemToAdd.localRotation = Quaternion.identity; 
            NumberOfItemsHolding++;
        });
        
        
    }
}
