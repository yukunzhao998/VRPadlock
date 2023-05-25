using System.Linq;
using UnityEngine;

public class vrPadLockPassword : MonoBehaviour
{
    VRMoveRuller _vrMoveRull;

    public int[] _numberPassword = { 0, 0, 0, 0 };

    private void Awake()
    {
        _vrMoveRull = FindObjectOfType<VRMoveRuller>();
    }

    public void Password()
    {
        if (_vrMoveRull._numberArray.SequenceEqual(_numberPassword))
        {
            // Here enter the event for the correct combination
            Debug.Log("Password correct");

            // Es. Below the for loop to disable Blinking Material after the correct password
            for (int i = 0; i < _vrMoveRull._rullers.Count; i++)
            {
                _vrMoveRull._rullers[i].GetComponent<PadLockEmissionColor>()._isSelect = false;
                _vrMoveRull._rullers[i].GetComponent<PadLockEmissionColor>().BlinkingMaterial();
            }

        }
    }
}
