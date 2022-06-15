using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    private bool isAlreadyCollected;
    private void OnTriggerEnter(Collider other)
    {
        if(isAlreadyCollected) return;
        
        if (other.CompareTag("Player"))
        {
            Collector m_collector;
            if (other.TryGetComponent(out m_collector))
            {
                m_collector.AddNewItem(this.transform);
                isAlreadyCollected = true;
            }
        }
    }
}
