using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propriedades : MonoBehaviour
{
    
    private Player _player = new Player();
    
    // Start is called before the first frame update
    void Start()
    {
        _player.Power = 200;

        Debug.Log(_player.GetPower());
    }

    public class Player
    {
        private int _power;

        public int Power
        {
            get { return _power; }
            set { _power = value;}
        }

        public int GetPower()
        {
            return _power;
        }
    }

}

