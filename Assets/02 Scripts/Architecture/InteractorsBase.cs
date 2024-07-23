using System;
using System.Collections.Generic;

namespace GameArchitecture
{
    public class InteractorsBase
    {
        private Dictionary<Type, Interactor> interactorsMap;
        private SceneConfig sceneConfig;

        public InteractorsBase(SceneConfig _sceneConfig)
        {
            sceneConfig = _sceneConfig;
        }

        public void CreateAllIneractors()
        {
            interactorsMap = sceneConfig.CreatAllInteractors();
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
