using System;
using System.Collections.Generic;

namespace GameArchitecture
{
    public class RepositoriesBase
    {
        private Dictionary<Type, Repository> repositoriesMap;
        private SceneConfig sceneConfig;

        public RepositoriesBase(SceneConfig _sceneConfig)
        {
            sceneConfig = _sceneConfig;
        }


        public void CreateAllRepositories()
        {
            repositoriesMap = sceneConfig.CreatAllRepositories();
        }


        public void SendOnCreateAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.OnCreate();
            }
        }

        public void InitializeAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.Initialize();
            }
        }

        public void StartAllRepositories()
        {
            foreach (var repository in repositoriesMap.Values)
            {
                repository.OnStart();
            }
        }

        public T GetRepository<T>() where T : Repository
        {
            var type = typeof(T);
            return (T)repositoriesMap[type];
        }

    }

}
