using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public abstract class AState
    {
        protected StateMachine<AState> _stateMachine;

        protected AState(StateMachine<AState> stateMachine)
        {
            _stateMachine = stateMachine;
        }

        public abstract void Enter();

        public abstract void Exit();

        public abstract void Update();
    }
}