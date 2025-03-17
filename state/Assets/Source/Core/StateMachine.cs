using Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public class StateMachine<T> where T : AState
    {
        private Dictionary<Type, T> _states;
        public T CurrentState;

        public StateMachine(ShootState shootState, HighlightState highlight, TransparentState transparentState)
        {
            _states = new Dictionary<Type, T>()
            {
                {typeof(ShootState),shootState as T },
                {typeof(HighlightState),highlight as T},
                {typeof(TransparentState),transparentState as T},
            };
        }

        public void ChangeState<T>()
        {
            //TODO find state of T type in dictionary
            if (CurrentState != null)
            {
                CurrentState.Exit();
            }
            CurrentState = _states[typeof(T)];
            CurrentState.Enter();
        }

        private Type MoveNext()
        {
            int nextId = 0;
            for (int i = 0; i < _states.Count; i++)
            {
                if (_states.Values.ElementAt(i).Equals(CurrentState))
                {
                    if (_states.Keys.Count > i + 1)
                    {
                        nextId = i + 1;
                    }
                }
            }
            return _states.Keys.ElementAt(nextId);
        }

        public void Update()
        {
            CurrentState?.Update();
        }
    }
}