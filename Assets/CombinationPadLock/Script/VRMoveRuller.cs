using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMoveRuller : MonoBehaviour
{
    vrPadLockPassword _lockPassword;
    PadLockEmissionColor _pLockColor;

    [HideInInspector]
    public List<GameObject> _rullers = new List<GameObject>();
    private int _scroolRuller = 0;

    [HideInInspector]
    public int[] _numberArray = { 0, 0, 0, 0 };

    private int _numberRuller = 0;

    private bool _isActveEmission = false;


    void Awake()
    {
        _lockPassword = FindObjectOfType<vrPadLockPassword>();
        _pLockColor = FindObjectOfType<PadLockEmissionColor>();

        _rullers.Add(GameObject.Find("Ruller1"));
        _rullers.Add(GameObject.Find("Ruller2"));
        _rullers.Add(GameObject.Find("Ruller3"));
        _rullers.Add(GameObject.Find("Ruller4"));

        foreach (GameObject r in _rullers)
        {
            r.transform.Rotate(-144, 0, 0, Space.Self);
        }
    }

    void Update()
    {
        _lockPassword.Password();
    }

    public void RotateRuller1()
    {
        _isActveEmission = true;
        _scroolRuller = 36;
        _rullers[0].transform.Rotate(_scroolRuller, 0, 0, Space.Self);

        _numberArray[0] -= 1;

        if (_numberArray[0] < 0)
        {
            _numberArray[0] = 9;
        }
    }
    public void RotateRuller2()
    {
        _isActveEmission = true;
        _scroolRuller = 36;
        _rullers[1].transform.Rotate(_scroolRuller, 0, 0, Space.Self);

        _numberArray[1] -= 1;

        if (_numberArray[1] < 0)
        {
            _numberArray[1] = 9;
        }
    }
    public void RotateRuller3()
    {
        _isActveEmission = true;
        _scroolRuller = 36;
        _rullers[2].transform.Rotate(_scroolRuller, 0, 0, Space.Self);

        _numberArray[2] -= 1;

        if (_numberArray[2] < 0)
        {
            _numberArray[2] = 9;
        }
    }
    public void RotateRuller4()
    {
        _isActveEmission = true;
        _scroolRuller = 36;
        _rullers[3].transform.Rotate(_scroolRuller, 0, 0, Space.Self);

        _numberArray[3] -= 1;

        if (_numberArray[3] < 0)
        {
            _numberArray[3] = 9;
        }
    }

}
