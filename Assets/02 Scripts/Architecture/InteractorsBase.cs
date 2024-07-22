using System;
using System.Collections.Generic;

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

        public void InitializeAllInteractors()
        {
            foreach (var interactor in interactorsMap.Values)
            {
                interactor.Initialize();
            }
        }

        public void StartAllInteractors()
        {
            foreach (var interactor in interactorsMap.Values)
            {
                interactor.OnStart();
            }
        }

        public T GetInteractor<T>() where T : Interactor
        {
            var type = typeof(T);
            return (T)interactorsMap[type];
        }

    }

}
