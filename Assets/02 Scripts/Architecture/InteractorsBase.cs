
using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameArchitecture
{
    public class InteractorsBase
    {
        private Dictionary<Type, Interactor> interactorsMap;

        public InteractorsBase()
        {
            interactorsMap = new Dictionary<Type, Interactor>();
        }

        public void CreateAllIneractors()
        {
            CreateInteractor<BankInteractor>();
        }


        private void CreateInteractor<T>() where T : Interactor, new()
        {
            var interactor = new T();
            interactorsMap[typeof(T)] = interactor;
        }


        public void SendOnCreateAllInteractors()
        {
            foreach (var interactor in interactorsMap.Values)
            {
                interactor.OnCreate();
            }
        }

        public void SendInitializeAllInteractors()
        {
            foreach (var interactor in interactorsMap.Values)
            {
                interactor.Initialize();
            }
        }

        public void SendOnStartAllInteractors()
        {
            foreach (var interactor in interactorsMap.Values)
            {
                interactor.OnStart();
            }
        }
    }

}
